using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementAPI.DTO
{
    public class CreateEmployeeDTO
    {
        [Required(ErrorMessage ="Enter the Valid FristName !!")]
        [StringLength(50,MinimumLength =3)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter the Valid LastName !!")]
        [StringLength(50, MinimumLength = 3)]
        public string LastName { get; set; }

        [Required(ErrorMessage ="!! Enter the Valid Email Id !!")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage ="!! Enter the valid Department !!")]
        [StringLength(50)]
        public string Department { get; set; }

        [Required]
        [Range(1000,1000000,ErrorMessage ="!! Enter the valid salary !!")]
        public Decimal Salary { get; set; }

        [Required]
        [DataType(DataType.Date,ErrorMessage ="!! Enter the Date in Correct formate !!")]
        public DateTime HireDate { get; set; }
    }
}
