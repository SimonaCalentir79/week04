using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp
{
    class Program
    {
        static void Main()
        {
            HotelManager newHotel = new HotelManager();
            var hotel1 = newHotel.CreateHotel();

            hotel1.Print();

            Console.WriteLine("\n");

            int i = 1;
            while (i <= 2)
            {
                Console.WriteLine("\n");
                newHotel.AddRoomToHotel(hotel1.Name);
                i++;
            }
            
            hotel1.Print();

            Console.WriteLine("\n");
            newHotel.UpdPriceOfRooms(hotel1.Name);

            hotel1.Print();

            Console.WriteLine("\n");
            newHotel.DeleteRoomFromHotel(hotel1.Name);

            hotel1.Print();
            //newHotel.PrintHotels();

            Console.ReadLine();
        }
    }
}
