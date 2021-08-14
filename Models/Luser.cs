using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Planner.Models
{
    public class Luser
    {
        [Required]
        [EmailAddress]
        public string LEmail {get;set;}
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8,ErrorMessage = "Password must be at least 8 chracters long!")]

        public string LPassword {get;set;}
    }
}