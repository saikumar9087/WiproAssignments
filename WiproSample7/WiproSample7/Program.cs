using WiproSample7;
namespace WiproSample7
{
    internal class Program
    {
        //public delegate void DelSample();
        //public delegate int DelInt(int i,int j);
        private static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //DelSample dl = new DelSample(Display);
            //dl();

            //DelInt dl2 = new DelInt(Add);
            //Console.WriteLine(dl2(1,2));

            /*List<Class1> cars = new List<Class1>() {

                new Class1(){CarName="Creta",EngineCC="1500cc",CarKMPL=18},
                new Class1(){CarName="Grand Vitara",EngineCC="1500cc",CarKMPL=22},
                new Class1(){CarName="Seltos",EngineCC="1500cc",CarKMPL=17},
                new Class1(){CarName="Astor",EngineCC="1300cc",CarKMPL=14},
                new Class1(){CarName="Kushaq",EngineCC="1000cc",CarKMPL=16},

            };

            DelCheck del = new DelCheck(IsCar);

            Class1.SelectCar(cars, IsCar);

            static bool IsCar(Class1 car)
            {

                if (car.CarKMPL > 18) { return true; }
                return false;





            }*/

            //static void Display()
            //{
            //    Console.WriteLine("this is delegate without parameter");
            //}

            //static int Add(int a, int b)
            //{
            //    return a + b;
            //}*/


            BtnDel btn = new BtnDel(Class1.Btn1);

            btn.Invoke(2);
            btn(1);
            btn(3);

            btn += Class1.Btn3;
            btn += Class1.Btn1;





            Func<int, int, int, int> fundel = delegate (int x, int y, int z)
            {
                return x + y + z;
            };

            
            Console.WriteLine(fundel(10, 20, 30));

            
            Func<int, int> fundellam = x => x * x;
            Console.WriteLine(fundellam(10));


            Action<int, int> actiondel = (x, y) => Console.WriteLine(x + y);

            actiondel(10, 20);

            Predicate<int> isEven = (num) => num % 2 == 0;

            if (isEven(10))  
            {
                Console.WriteLine("Num value is even");
            }
            else
            {
                Console.WriteLine("Num values is odd");
            }








        }

    }
}
