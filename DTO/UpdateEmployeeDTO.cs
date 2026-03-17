using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementAPI.DTO
{
    public class UpdateEmployeeDTO
    {
        [Required(ErrorMessage = "Enter the Valid FristName !!")]
        [StringLength(50, MinimumLength = 3)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter the Valid LastName !!")]
        [StringLength(50, MinimumLength = 3)]
        public string LastName { get; set; }

        [Required(ErrorMessage ="Enter the valid Email !!")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage ="Enter the Valid Department !!")]
        [StringLength(50)]
        public string Department { get; set; }

        [Required(ErrorMessage ="Enter the Valid Salary !!")]
        [Range(1000, 1000000)]
        public Decimal Salary { get; set; }

        [Required(ErrorMessage ="Enter the valid Date Formate !!")]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }
    }
}
