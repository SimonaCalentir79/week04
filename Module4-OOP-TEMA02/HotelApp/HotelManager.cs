using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp
{
    public class HotelManager
    {
        private List<Rate> lstPrices = new List<Rate>();
        private List<Room> lstRooms = new List<Room>();
        private List<Hotel> lstHotels = new List<Hotel>();

        public Rate CreateRate()
        {
            Console.Write("\t Price: ");
            var amount = Convert.ToDecimal(Console.ReadLine());

            Console.Write("\t Currency: ");
            var currency = Console.ReadLine();

            var newRate = new Rate(amount , currency);
            lstPrices.Add(newRate);

            return newRate;
        }
        public void PrintRates()
        {
            foreach (var rate in lstPrices)
            {
                rate.Print();
            }
        }
        public Room CreateRoom()
        {
            Console.WriteLine("\t Room name: ");
            var roomname = Console.ReadLine();

            Console.WriteLine("\t Adults: ");
            int adults = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\t Children: ");
            int children = Convert.ToInt32(Console.ReadLine());

            var dailyrate = this.CreateRate();

            var newRoom = new Room(roomname, dailyrate ,adults, children);
            lstRooms.Add(newRoom);

            return newRoom;
        }
        public void PrintRooms()
        {
            foreach (var room in lstRooms)
            {
                room.Print();
            }
        }
        public Hotel CreateHotel()
        {
            Console.WriteLine("\t Hotel name: ");
            var hotelname = Console.ReadLine();

            Console.WriteLine("\t City: ");
            var city = Console.ReadLine();

            Console.WriteLine("\t Stars:");
            var stars = Convert.ToInt32(Console.ReadLine ());

            var rooms = new List<Room> {this.CreateRoom()};

            var newHotel = new Hotel(hotelname , city , stars , rooms);
            lstHotels.Add(newHotel);

            return newHotel;

        }
        public void UpdPriceOfRooms(string nameOfHotel)
        {
            Console.WriteLine("\t Name of the room who's price you want to update: ");
            string nameOfRoom = Console.ReadLine();

            Console.WriteLine("\t New price: ");
            decimal newPrice = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\t New currency: ");
            string newCurrency = Console.ReadLine();

            foreach (var hotel in lstHotels)
            {
                if (hotel.Name == nameOfHotel)
                {
                    foreach (var room in hotel.Rooms)
                    {
                        if (room.Name == nameOfRoom)
                        {
                            room.DailyRate.Amount = newPrice;
                            room.DailyRate.Currency = newCurrency;
                        }
                    }
                }
            }
        }
        public void AddRoomToHotel(string nameOfHotel)
        {
            var newRoom = this.CreateRoom();

            foreach (var hotel in lstHotels)
            {
                if (hotel.Name == nameOfHotel)
                {
                    hotel.Rooms.Add(newRoom);
                }
            }
        }
        public void DeleteRoomFromHotel(string nameOfHotel)
        {
            Console.WriteLine("\t Name of the room which you want to delete: ");
            string nameOfRoom = Console.ReadLine();
            foreach (var hotel in lstHotels)
            {
                if (hotel.Name == nameOfHotel)
                {
                    foreach (var room in hotel.Rooms.ToList())
                    {
                        if (room.Name == nameOfRoom)
                        {
                            hotel.Rooms.Remove(room);
                        }
                    }
                }
            }
        }
        public void PrintHotels()
        {
            foreach (var hotel in lstHotels)
            {
                hotel.Print();
            }
        }
    }
}
