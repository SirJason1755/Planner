using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Planner.Models
{
    public class User
    {   [Key]
        public int UserID {get;set;}
        [Required]
        public string FirstName {get;set;}
        [Required]
        public string LastName {get;set;}
        [Required]
        [EmailAddress]
        public string Email {get;set;}
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8,ErrorMessage = "Password must be at least 8 chracters long!")]
        
        public string Password {get;set;}
        [Required]
        public DateTime CreatedAt {get;set;} = DateTime.Now;

        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public List<RSVP> WeddingsToAttend {get;set;}

        public List<Wedding> PlannedWedding {get;set;}

        [NotMapped]
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string Confirm {get;set;}

        


    }
}