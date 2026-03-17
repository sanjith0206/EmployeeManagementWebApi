using EmployeeManagementAPI.Data;
using EmployeeManagementAPI.DTO;
using EmployeeManagementAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementAPI.Service
{
    public class EmployeeService
    {
        private readonly EmployeeTable context;

        public EmployeeService(EmployeeTable context)
        {
            this.context = context;
        }

        public async Task<List<EmployeeResponse>> GetEmployee()
        {
            var Employee = await context.Employees.ToListAsync();
            List<EmployeeResponse> employee = new List<EmployeeResponse>();
            foreach(var item in Employee)
            {
                if (item.IsActive)
                {
                    EmployeeResponse dto = new EmployeeResponse();
                    dto.Id = item.Id;
                    dto.FirstName = item.FirstName;
                    dto.LastName = item.LastName;
                    dto.Department = item.Department;
                    dto.Salary = item.Salary;
                    dto.HireDate = item.HireDate;

                    employee.Add(dto);
                }
            }
            return employee;
        }

        public async Task<EmployeeResponse> GetByIdEmployee(int id)
        {
            var Employee = await context.Employees.FindAsync(id);

            if (Employee == null)
                return null;

            if (!Employee.IsActive)
                return null;

            EmployeeResponse dto = new EmployeeResponse();
            dto.Id = Employee.Id;
            dto.FirstName = Employee.FirstName;
            dto.LastName = Employee.LastName;
            dto.Department = Employee.Department;
            dto.Salary = Employee.Salary;
            dto.HireDate = Employee.HireDate;

            return dto;
        }

        public async Task<CreateEmployeeDTO>  AddEmployee(CreateEmployeeDTO Employee)
        {
            EmployeeModel Entity = new EmployeeModel();
            Entity.FirstName = Employee.FirstName;
            Entity.LastName = Employee.LastName;
            Entity.Email = Employee.Email;
            Entity.Department = Employee.Department;
            Entity.Salary = Employee.Salary;
            Entity.HireDate = Employee.HireDate;

            await context.Employees.AddAsync(Entity);
            await context.SaveChangesAsync();

            CreateEmployeeDTO dto = new CreateEmployeeDTO();
            dto.FirstName= Employee.FirstName;
            dto.LastName= Employee.LastName;
            dto.Email = Employee.Email;
            dto.Department= Employee.Department;
            dto.Salary = Employee.Salary;
            dto.HireDate= Employee.HireDate;

            return dto;
        }

        public async Task<string> DeleteEmployee(int id)
        {
            var oldEmployee = await context.Employees.FindAsync(id);
            if (oldEmployee == null)
                return ("!! There is no employee in that Id !!");

            if (!oldEmployee.IsActive)
                return ("!! The Employee is not Currently Active !!");

            oldEmployee.IsActive = false;
            await context.SaveChangesAsync();
            return ("!! Deletion occurred Successfully !!");

        }

        public async Task<string> updateEmployee(int id,UpdateEmployeeDTO Employee)
        {
            var oldEmployee = await context.Employees.FindAsync(id);
            if (oldEmployee == null)
                return ("!! There is no employee in that Id !!");

            if (!oldEmployee.IsActive)
                return ("!! The Employee is not Currently Active !!");

            oldEmployee.FirstName = Employee.FirstName;
            oldEmployee.LastName = Employee.LastName;
            oldEmployee.Email = Employee.Email;
            oldEmployee.Department = Employee.Department;
            oldEmployee.Salary = Employee.Salary;
            oldEmployee.HireDate = Employee.HireDate;

            await context.SaveChangesAsync();
            return ("!! Updatation Occurred Successfully !!");
        }
    }
}

