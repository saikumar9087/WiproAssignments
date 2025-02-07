using WiproSample4AbstractClass;

internal class Program
{
    private static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");


        //ChkAge ch=new ChkAge() { VoterId=123,VoterName="sai",age=19};

        //ch.VoterDetails();
        //ch.CheckAge();

        string? ch;
        do
        {
            Console.Write("1.Add 2.Sub = ");
            string? type = Console.ReadLine().ToLower();

            switch (type.ToLower())
            {
                case "add":
                    IShape ish = new ClaAdd() { a=10,b=10 };
                    ish.Calci();
                    break;
                case "sub":
                    IShape rec = new ClaSub() { a = 10, b = 5 };
                    rec.Calci();
                    break;
                default:
                    IShape sq = new ClaAdd();
                    sq.DefaultCalci();
                    break;
            }
            Console.WriteLine("Do you want to continue (yes/no):");
            ch = Console.ReadLine();
        } while (ch.Equals("yes"));



    }
}