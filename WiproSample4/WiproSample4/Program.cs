using WiproSample4;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        /*Employee emp=new Employee();

        Console.Write("enter the emp id: ");
        emp.EmpId=Convert.ToInt32(Console.ReadLine());

        Console.Write("enter the emp name: ");
        emp.EmpName=Console.ReadLine();


        Department dept=new Department();

        Console.Write("enter the dept id: ");
        dept.DeptId=Convert.ToInt32(Console.ReadLine());

        Console.Write("enter the dept name: ");
        dept.DeptName=Console.ReadLine();
        dept.EmpName = "sai2";
        dept.EmpId = 102;

        Manager mng = new Manager();

        mng.MangName = "sathwik";
        mng.DeptName = "HR";
        mng.DeptId = 2;
        mng.EmpId = 2;
        mng.EmpName = "sathwik2";

        emp.display();
        dept.display();
        mng.display();*/

        Console.Write("enter the emp id: ");
        int id=Convert.ToInt32(Console.ReadLine());

        Console.Write("enter dept id: ");
        int dept_id=Convert.ToInt32(Console.ReadLine());

        Console.Write("enter dept name: ");
        string? dept_name=Console.ReadLine();

        Console.Write("enter the manager name: ");
        string? mng_name=Console.ReadLine();

        Manager mng=new Manager(id, dept_id,dept_name, mng_name);

        mng.display();




        
        



    }
}