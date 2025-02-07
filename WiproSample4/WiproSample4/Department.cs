using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiproSample4
{
    internal class Department:Employee
    {
        public int DeptId { get; set; }
        public string? DeptName { get; set; }

        public Department(int id,int deptId, string? deptName):base(id)
        {
            DeptId = deptId;
            DeptName = deptName;
        }

        public override void display()
        {
            
            Console.WriteLine($"Dept id = {DeptId}\nDept name = {DeptName}\n");
            base.display();



        }
    }
}
