using WiproSample2;

internal static class Class2Helpers
{
    private static void Main(string[] args)
    {
        Console.Write("enter emp id: ");
        int emid = Convert.ToInt32(Console.ReadLine());

        Console.Write("enter emp name: ");
        String? ename = Console.ReadLine();


        Class1 emp = new Class1(emid, ename);

        Console.Write("emp id is :" + emp.emp_Id);
        Console.Write("emp name is :  " + emp.emp_name);


    }
}