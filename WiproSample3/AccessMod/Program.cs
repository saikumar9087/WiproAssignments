using System;
using WiproSample3;

namespace AccessMod {
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");


            //Employee emp = new Employee();

            //Console.Write("enter the emp domain name: ");
            //emp.empdomain = Console.ReadLine();

            //Console.Write("enter the emp location: ");
            //emp.emploc = Console.ReadLine();

            //emp.EmpDetails();

            Crud[] cs = new Crud[2];

            for (int i = 0; i < cs.Length; i++)
            {

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

            for (int i = 0; i < cs.Length; i++)
            {

                Console.WriteLine($"emp name = {cs[i].EmpName}\n emp id = {cs[i].EmpId}\n emp dept = {cs[i].EmpDomain}\n emp salary = {cs[i].EmpSal}\n\n");

            }

        }
    }
}

