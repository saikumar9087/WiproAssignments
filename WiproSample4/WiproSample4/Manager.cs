using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiproSample4
{
    internal class Manager:Department
    {

        public string MangName {  get; set; }


        public Manager(int id, int dept_id, string dept_name,string mangName):base(id,dept_id,dept_name)
        {
            MangName = mangName;
        }

        public override void display()
        {
            
            Console.Write($"Manager name = {MangName}\n");
            base.display();
        }
    }
}
