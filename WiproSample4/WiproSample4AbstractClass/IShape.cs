using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiproSample4AbstractClass
{
    internal interface IShape
    {

        void Calci();

        void DefaultCalci()
        {
            Console.WriteLine("Return to zero");
        }
    }

    class ClaAdd : IShape
    {
        public int a { get; set; }
        public int b { get; set; }

        public void Calci() {

            Console.WriteLine($"addtion of {a} & {b} = {a + b}");
        }
    }

    class ClaSub : IShape
    {
        public int a { get; set; }
        public int b { get; set; }

        public void Calci()
        {

            Console.WriteLine($"subtraction of {a} & {b} = {a - b}");
        }
    }
}
