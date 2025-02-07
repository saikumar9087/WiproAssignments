using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WiproSample2
{
    internal class Class1
    {

        public int emp_Id { get; set; }
        public string emp_name { get; set; }


        public Class1(int emp_Id, string emp_name)
        {
            this.emp_Id = emp_Id;
            this.emp_name = emp_name;
        }
    }
}
