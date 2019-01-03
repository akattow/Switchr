using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Switchr.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.Unknown
                || customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;

            if (customer.Birthdate == null)
                return new ValidationResult("Customer must be at least 18 years old to select a recurring plan.");

            //var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            //return (age >= 18
            //    ? ValidationResult.Success : new ValidationResult("Customer must be at least 18 years old to select a recurring plan."));

            var targetDate = DateTime.Now.AddYears(-21);

            var age = customer.Birthdate.Value;

            return (age < targetDate
                ? ValidationResult.Success : new ValidationResult("Customer must be at least 18 years old."));
        }
    }
}