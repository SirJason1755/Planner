using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Planner.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Identity;

namespace Planner.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
        public HomeController(MyContext context)
        {
            _context = context;
        }

        public User LoggedInUser()
        {
            int? LoggedID = HttpContext.Session.GetInt32("loggedin");
            User logged = _context.Users.FirstOrDefault(u => u.UserID == LoggedID);
            return logged;
        }

        public int UserID()
        {
            int UserID = LoggedInUser().UserID;
            return UserID;
        }



        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User newUser)
        {
            if (ModelState.IsValid)
            {
                if (_context.Users.Any(e => e.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("Index");
                }
                else
                {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                    _context.Add(newUser);
                    _context.SaveChanges();
                    HttpContext.Session.SetInt32("loggedin", newUser.UserID);
                    return RedirectToAction("Dashboard");
                }
            }
                else
                {
                    return View("Index");
                }
        }

            [HttpPost("login")]
            public IActionResult Login(Luser logUser)
            {
                if (ModelState.IsValid)
                {
                    User userInDb = _context.Users.FirstOrDefault(u => u.Email == logUser.LEmail);
                    if (userInDb == null)
                    {
                        ModelState.AddModelError("LEmail", "Invalid login attempt");
                        return View("Index");
                    }
                    PasswordHasher<Luser> Hasher = new PasswordHasher<Luser>();
                    PasswordVerificationResult result = Hasher.VerifyHashedPassword(logUser, userInDb.Password, logUser.LPassword);
                    if (result == 0)
                    {
                        ModelState.AddModelError("LEmail", "Invalid login attempt");
                        return View("Index");
                    }
                    else
                    {
                        HttpContext.Session.SetInt32("loggedin", userInDb.UserID);
                        return RedirectToAction("Dashboard");
                    }
                }
                else
                {
                    return View("Index");
                }
            }

            [HttpGet("Dashboard")]
            public IActionResult Dashboard()
            {
                if (LoggedInUser() != null)
                {   

                    List<Wedding> AllWeddings = _context.Weddings
                                                    .Include(w => w.Planner)
                                                    .Include(g => g.GuestList)
                                                    .ToList();
                    ViewBag.AllWeddings = AllWeddings;
                    ViewBag.User = LoggedInUser();
                    return View();
                    // return Redirect($"/{UserID()}/page")
                }
                else
                {
                    ModelState.AddModelError("LEmail", "Invalid login Attempt!");
                    return View("Index");
                }

            }

            [HttpGet("Weddings")]
            public IActionResult Weddings()
            {
                ViewBag.UserID = UserID();
                return View();
            }

            [HttpPost("create")]

            public IActionResult AddWedding(Wedding NewWedding)
            {
                if (ModelState.IsValid)
            {   
                _context.Add(NewWedding);
                _context.SaveChanges();
                return RedirectToAction("Dashboard");
            }
            else
            {
                return View("Weddings");
            }
            }
            [HttpGet("/rsvp/{WID}/{UserId}")]
            public IActionResult RSVP(int WID, int UserId)
            {
                RSVP r = new RSVP();
                r.WeddingID = WID;
                r.UserID = UserId;
                _context.Add(r);
                _context.SaveChanges();
                return RedirectToAction("Dashboard");

            }
            [HttpGet("/unrsvp/{WID}/{UserId}")]
            public IActionResult unRSVP(int WID, int UserId)
            {
                RSVP r = _context.RSVPs.FirstOrDefault(r => r.WeddingID == WID && r.UserID == UserId);
                _context.Remove(r);
                _context.SaveChanges();
                return RedirectToAction("Dashboard");

            }

            [HttpGet("/delete/{WID}")]
            public IActionResult DeleteWedding(int WID)
            {
                Wedding deleteDis = _context.Weddings.FirstOrDefault(w => w.WeddingID == WID);
                _context.Remove(deleteDis);
                _context.SaveChanges();
                return RedirectToAction("Dashboard");
            }


            [HttpGet("onewedding/{WeddingId}")]

            public IActionResult OneWedding(int WeddingId)
            {
                ViewBag.Wedding = _context.Weddings
                                                    .Include(g => g.GuestList)
                                                    .ThenInclude(a => a.Attendee)
                                                    .FirstOrDefault(w => w.WeddingID == WeddingId);
                return View();
            }

            



            [HttpGet("logout")]
            public IActionResult Logout()
            {
                HttpContext.Session.Clear();
                return RedirectToAction("Index");
            }
        }
    }
