using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiproSample6
{
    internal interface IRoom<T>
    {
        IEnumerable<T> GetAll();
        void AddRoom(T item);
    }

    internal class RoomAC()
    {
        public int RoomNum { get; set; }
        public string RoomType { get; set; }

        public int RoomPrice { get; set; }


    }

    internal class RoomNonAc() {


        public int RoomNum { get; set; }
        public string RoomType { get; set; }

        public int RoomPrice { get; set; }


    }


    internal class Hotel : IRoom<RoomAC>, IRoom<RoomNonAc>
    {


        List<RoomAC> lsac = new List<RoomAC>()
        {
            new RoomAC(){RoomNum=101,RoomType="Single",RoomPrice=3000},
            new RoomAC(){RoomNum=102,RoomType="Double",RoomPrice=4000}

        };

        List<RoomNonAc> lsnac = new List<RoomNonAc>()
        {
            new RoomNonAc(){RoomNum=201,RoomType="Single",RoomPrice=2000},
            new RoomNonAc(){RoomNum=202,RoomType="Double",RoomPrice=3000}

        };
        public void AddRoom(RoomAC item)
        {
            lsac.Add(item);
            Console.WriteLine($"Room num = {item.RoomNum}\t Room Type = {item.RoomType}\t Room Price = {item.RoomPrice}");
            
        }

        public void AddRoom(RoomNonAc item)
        {
            lsnac.Add(item);
            Console.WriteLine($"Room num = {item.RoomNum}\t Room Type = {item.RoomType}\t Room Price = {item.RoomPrice}");
        }

        public IEnumerable<RoomAC> GetAll()
        {
            return lsac;
        }

        IEnumerable<RoomNonAc> IRoom<RoomNonAc>.GetAll()
        {
            return lsnac;
        }
    }



}
