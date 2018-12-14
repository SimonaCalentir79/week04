using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp
{
    public class Hotel
    {
        private List<Hotel> lstHotels = new List<Hotel>();

        public Hotel(string name, string city, int stars, List <Room> rooms)
        {
            this.Name = name;
            this.City = city;
            this.Stars = stars;
            this.Rooms = rooms;
        }

        public string Name { get; set; }

        public string City { get; set; }

        public int Stars { get; set; }

        public List<Room> Rooms { get; set; }

        public decimal GetPriceForAllRooms()
        {
            decimal x = 0;
            foreach (var room in Rooms)
            {
                x = x + room.DailyRate.Amount;
            }
            return x;
        }
        public void DeleteHotel(string nameOfHotelToDelete)
        {
            foreach (var hotelFromLstHotels in lstHotels)
            {
                if (hotelFromLstHotels.Name == nameOfHotelToDelete)
                {
                    lstHotels.Remove(hotelFromLstHotels);
                }
            }
        }
        public void Print()
        {
            Console.WriteLine($"Hotel: {Name}");
            Console.WriteLine($"\t City: {City}, Stars: {Stars}");
            foreach (var room in Rooms)
            {
                room.Print();
            }
        }
    }
}
