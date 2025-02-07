using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiproSample3;

namespace AccessMod
{
    internal class Pro2

    {
        private static void main(string[] args)
        {
            System.Console.WriteLine("hello");


            Crud[] cs = new Crud[2];

            for (int i = 0;i<cs.Length; i++){

                Console.Write("Enter EmployeeId: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter EmployeeName: ");
                string name = Console.ReadLine();
                Console.Write("Enter Dept: ");
                string dpt = Console.ReadLine();
                Console.Write("Enter Salary: ");
                decimal sal = Convert.ToDecimal(Console.ReadLine());


                cs[i] = new Crud(id, name, dpt, sal);


            }

            for (int i = 0; i < cs.Length; i++) {

                Console.WriteLine($"emp name = {cs[i].EmpName}\n emp id = {cs[i].EmpId}\n emp dept = {cs[i].EmpDomain}\n emp salary = {cs[i].EmpSal}");
            
            }



        }
    }
}
