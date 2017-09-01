using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Practice.Models
{
    public class IsCustomerOver18 : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            bool isMember = false;

            if (customer.MembershipTypeId > 1) // tells if the customer is member
                isMember = true;

            if (!isMember) // if they are not a member then we don't need a birthdate
                return ValidationResult.Success;

            if (customer.Birthdate == null)  
                return new ValidationResult("Birthdate is required");

            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;
            return (age >= 18) 
                ? ValidationResult.Success 
                : new ValidationResult("You need to be at least 18 years to be a member.");
        }
    }
}