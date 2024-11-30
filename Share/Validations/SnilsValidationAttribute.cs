using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Share.Validations
{
    public class SnilsValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {
            if (value is not string snils)
                return new ValidationResult("СНИЛС должен быть строкой.");
    
            var regex = new Regex(@"^\d{3}-\d{3}-\d{3} \d{2}$");
            if (!regex.IsMatch(snils))
                return new ValidationResult("СНИЛС должен быть в формате '001-001-001 01'.");
    
            return ValidationResult.Success!;
        }
    }
}
