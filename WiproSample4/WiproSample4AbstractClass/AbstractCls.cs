using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiproSample4AbstractClass
{
    internal abstract class AbstractCls
    {

        public string? VoterName { get; set; }
        public int VoterId {  get; set; }

        public void VoterDetails()
        {
            Console.WriteLine($"voter name is {VoterName}\nVoter id is {VoterId}");
        }

        public abstract void CheckAge();


    }

    class ChkAge : AbstractCls
    {
        public int age { get; set; }

        public override void CheckAge()
        {
            if (age < 18)
            {
                Console.WriteLine("Not eligible for voting");
            }
            else
            {
                Console.WriteLine("Eligible for voting");
            }
        }

    }   
}
