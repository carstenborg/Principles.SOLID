using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principles.SOLID.SingleResponsibility.Correct
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }

    public interface IEmployeeStorage
    {
        void Save(Employee employee);
    }

    public class EmployeeStorage : IEmployeeStorage
    {
        public void Save(Employee employee)
        {
            // Save employee to database
        }
    }

    public interface IMailService
    {
        void SendMail();
    }

    public class EmployeeService
    {
        private readonly IEmployeeStorage _employeeStorage;
        private readonly IMailService _mailService;

        public EmployeeService(IEmployeeStorage employeeStorage)
        {
            _employeeStorage = employeeStorage;
        }

        public void AddEmployee(Employee employee)
        {
            // Validate employee data
            _employeeStorage.Save(employee);
         }
    }


}
