using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessMod
{
    internal class Crud
    {
        public int EmpId { get; set; }
        public string EmpName {  get; set; }

        public string EmpDomain {  get; set; }

        public decimal EmpSal {  get; set; }

        public Crud(int EmpId,string EmpName,string EmpDomain,decimal Empsal) {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.EmpDomain = EmpDomain;
            this.EmpSal = Empsal;


        }

        public void Disp()
        {
            Console.WriteLine($"id={EmpId}  name={EmpName}  domain={EmpDomain} salary={EmpSal}");
        }


    }
}
