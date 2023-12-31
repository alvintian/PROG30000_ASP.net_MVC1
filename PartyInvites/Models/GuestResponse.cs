﻿using System.ComponentModel.DataAnnotations;
namespace PartyInvites.Models
{
    //class used for storing and displaying error messages
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+",
        ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please specify whether you'll attend")]
        public bool? WillAttend { get; set; }
        [Required(ErrorMessage = "Please enter your address")]
        public string Address { get; set; }  
        [Required(ErrorMessage = "Please enter your Twitter account")]
        public string TwitterAccount { get; set; } 
        [Required(ErrorMessage = "Please specify your technical interest")]
        public TechnicalInterest Interest { get; set; }

    }
}
