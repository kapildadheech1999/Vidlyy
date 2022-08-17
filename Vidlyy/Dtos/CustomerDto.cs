using System;
using System.ComponentModel.DataAnnotations;

namespace Vidlyy.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customers name.")]
        [StringLength(255, ErrorMessage = "Length should be less than or equal to 255.")]
        public string Name { get; set; }

        //[Models.Min18YearsIfAMember]
        public DateTime? Dob { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipTypeDto MembershipType { get; set; }

        [Required]
        public byte MembershipTypeId { get; set; }
    }
}