using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Planner.Models
{
    public class Wedding
    {
        [Key]

        public int WeddingID {get;set;}
        [Required]
        public string WedderOne {get;set;}
        [Required]
        public string WedderTwo {get;set;}
        [Required]
        [DataType(DataType.Date)]

        public DateTime Date{get;set;}

        public string Address {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public int UserID {get;set;}

        public User Planner {get;set;}

        public List<RSVP> GuestList {get;set;}

        
    }
}