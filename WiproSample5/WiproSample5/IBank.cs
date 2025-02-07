using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiproSample5
{
    internal interface IBank
    {

        public void BankManager();

        public void BankEmployee();
    }

    internal interface IVault
    {
        public void VaultStock();
        
    }


    public class BankM : IBank, IVault
    {
        public string ManagerName { get; set; }
        public string ManagerId { get; set; }


       



        public void BankManager()
        {
            Console.WriteLine($"Manager name: {ManagerName} and id = {ManagerId}");
            
        }

        public void VaultStock()
        {
            Console.WriteLine("Check the stock in the vault");

        }



        public void BankEmployee()
        {
            throw new NotImplementedException();
        }
    }

    public class BankE : IBank
    {
        public string EmpName { get; set; }
        public string EmpId { get; set; }

        

       

        public void BankEmployee()
        {
            Console.WriteLine($"Employee name: {EmpName} and id = {EmpId}");

        }

        public void BankManager()
        {
            throw new NotImplementedException();
        }
    }
}
