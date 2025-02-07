internal class Program
{
    private static void Main(string[] args)
    {
        /*Console.WriteLine("enter your name:");
        String? name=Console.ReadLine();

        Console.WriteLine("enter your current location: ");
        String? loc=Console.ReadLine(); 

        Console.WriteLine("What's your age, plz enter: ");
        int? age= Convert.ToInt32(Console.ReadLine());


        Console.WriteLine($"Your name: {name}\nYour location: {loc}\nYour age: {age}");



        int? a = null;
        int? b = a ?? 101;

        Console.WriteLine($"the value will be {b} , {a} & {b}");*/

        String str = "five";
        int res;
        Console.WriteLine(int.TryParse(str, out res));

        String str1 = "5";
        int res1;
        Console.WriteLine(int.TryParse(str1,out res1));

        Console.WriteLine("enter your age:");
        String? age1=Console.ReadLine();


        int cur_age=Boolean.TryParse(age1,out res);
        

    }
}