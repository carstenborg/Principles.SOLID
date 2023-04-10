using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principles.SOLID.SingleResponsibility.Incorrect
{

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public void AddToStorage()
        {
            // Save to storage
        }

        public void SendMail()
        {
            // Send mail
        }

    }

}
