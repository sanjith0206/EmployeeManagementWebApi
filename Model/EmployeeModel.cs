namespace EmployeeManagementAPI.Model
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string FirstName { get; set;}
        public string LastName { get; set;}
        public string Email { get; set;}
        public string Department { get; set; }
        public Decimal Salary { get; set; }
        public DateTime HireDate { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
