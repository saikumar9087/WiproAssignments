using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WiproSample7
{
    //public delegate bool DelCheck(Class1 cls);
    public delegate void BtnDel(int a);
    public class Class1
    {
        
       /* public string CarName { get; set; }
        public string EngineCC { get; set; }
        public int CarKMPL { get; set; }

        public static void SelectCar(List<Class1> cars, DelCheck IsCar)
        {
            foreach (Class1 car in cars) {
                if (IsCar(car)) { 
                    Console.WriteLine($"The best car will be {car.CarName}");
                }


            }

        }*/

        public static void Btn1(int a)
        {
            Console.WriteLine($"Button {a} clicked");
        }
        public static void Btn2(int a)
        {
            Console.WriteLine($"Button {a} clicked");
        }
        public static void Btn3(int a)
        {
            Console.WriteLine($"Button {a} clicked");
        }

    }
}
