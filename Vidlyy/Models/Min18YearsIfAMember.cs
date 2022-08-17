using System;
using System.ComponentModel.DataAnnotations;

namespace Vidlyy.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            if (customer.MembershipTypeId == MembershipType.UnKnown || customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;
            if (customer.Dob == null)
                return new ValidationResult("BirthDate is required.");
            DateTime now = DateTime.Now;
            TimeSpan daysPassed = now.Subtract((DateTime)customer.Dob);
            return ((daysPassed.Days / 365) >= 18) ? ValidationResult.Success : new ValidationResult("Customer should be at least 18 years old to go on membership");

        }
    }
}