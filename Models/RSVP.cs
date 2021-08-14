using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;



namespace Planner.Models
{
    public class RSVP
    {
        [Key]

        public int RSVPID {get;set;}

        public int UserID {get;set;}

        public int WeddingID {get;set;}

        public User Attendee {get;set;}

        public Wedding Wedding {get;set;}
    }
}