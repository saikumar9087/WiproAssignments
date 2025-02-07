using WiproSample5;

internal class Program
{
    static class MathHelper //efficient for utility functions - static members & static functions
    {
        public static int count = 0;//static field
        public static double square(double num)
        {
            return num * num;
        }
        public static double square(int num)
        {
            return num * num;
        }
        public static double Cube(double num)
        {
            return num * num * num;
        }
        public static void Dsiplay()
        {
            count++;
            Console.WriteLine(count);
        }
    }
    private static void Main(string[] args)
    {
        BankM bm = new BankM() { ManagerId="101",ManagerName="sai"};

        BankE be = new BankE() { EmpName = "sathwik", EmpId = "102" };

        bm.BankManager();
        bm.VaultStock();
        be.BankEmployee();

        MathHelper.Dsiplay();
    }
}