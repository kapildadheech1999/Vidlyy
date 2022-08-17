﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Vidlyy.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customers name.")]
        [StringLength(255, ErrorMessage = "Length should be less than or equal to 255.")]
        public string Name { get; set; }

        [Display(Name = "Date Of Birth")]
        [Min18YearsIfAMember]
        public DateTime? Dob { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        [Required]
        public byte MembershipTypeId { get; set; }
    }
}