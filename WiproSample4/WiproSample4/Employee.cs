using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiproSample4
{
    internal class Employee
    {

        public int EmpId { get; set; }
        public string? EmpName { get; set; }

        public Employee(int empId)
        {
            EmpId = empId;
            
        }

        public virtual void display()
        {
            Console.WriteLine($"emp id = {EmpId}\nemp name = {EmpName}");
        }
    }
}
