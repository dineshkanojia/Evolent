using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment.Models
{
    public class ContactViewModel
    {
        public Guid ContactId { get; set; }

        [Required,StringLength(50,ErrorMessage ="First Name must not be more than 50 char")]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required, StringLength(50, ErrorMessage = "Last Name must not be more than 50 char")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required, StringLength(100, ErrorMessage = "Email id must not be more than 100 char")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Display(Name = "Email Id")]
        public string Email { get; set; }

        [Required, StringLength(15, ErrorMessage = "Phone Number must not be more than 15 char")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        public bool IsActive { get; set; }

        public string Status { get; set; }

        public DateTime? CreateDate { get; set; }

    }
}