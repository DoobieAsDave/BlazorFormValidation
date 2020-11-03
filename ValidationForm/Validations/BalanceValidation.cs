using System.ComponentModel.DataAnnotations;

namespace ValidationForm.Validations
{
    public class BalanceValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return null;
            }

            if (!decimal.TryParse(value.ToString(), out var balance))
            {
                return new ValidationResult("Number is not valid", new[] { validationContext.MemberName });
            }

            if (balance < 0)
            {
                return new ValidationResult("Number must be greater or equal to 0", new[] { validationContext.MemberName });
            }

            return balance % 1 == 0
                ? null
                : new ValidationResult("Number does not allow any decimals", new[] { validationContext.MemberName });
        }
    }
}
