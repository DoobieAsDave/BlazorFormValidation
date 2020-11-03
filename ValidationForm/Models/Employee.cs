using ValidationForm.Validations;

namespace ValidationForm.Models
{
    using System.ComponentModel.DataAnnotations;


    public class Employee
    {
        [StringLength(20)]
        public string FirstName { get; set; }

        [StringLength(maximumLength: 50, MinimumLength = 3)]
        public string LastName { get; set; }

        public string NickName { get; set; }

        [Range(minimum: 1900, maximum: 2020)]
        public int? YearOfBirth { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [BalanceValidation]
        public decimal? Balance { get; set; }
    }
}