using WiproSample6;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        Hotel htl = new Hotel();
        IEnumerable<RoomAC> result = htl.GetAll();

        foreach (RoomAC r in result)
        {
            Console.WriteLine(r.RoomNum + " " + r.RoomType + " " + r.RoomPrice);
        }

        htl.AddRoom(new RoomAC() { RoomNum = 115, RoomType = "Double", RoomPrice = 8000 });
        IEnumerable<RoomNonAc> resultn = ((IRoom<RoomNonAc>)htl).GetAll();

        foreach (RoomNonAc r in resultn)
        {
            Console.WriteLine(r.RoomNum + " " + r.RoomType + " " + r.RoomPrice);
        }


        htl.AddRoom(new RoomNonAc() { RoomNum = 115, RoomType = "Double", RoomPrice = 8000 });
    }
}