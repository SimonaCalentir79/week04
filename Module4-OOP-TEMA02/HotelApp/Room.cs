using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp
{
    public class Room
    {
        private List<Room> lstRooms = new List<Room>();

        public Room(string name, Rate dailyrate, int adults, int children)
        {
            this.Name = name;
            this.DailyRate = dailyrate;
            this.Adults = adults;
            this.Children = children;
        }

        public string Name { get; set; }

        public Rate DailyRate { get; set; }

        public int Adults { get; set; }

        public int Children { get; set; }

        public decimal GetPrice()
        {
            if (this.Children == 1)
            {
                return this.DailyRate.Amount * Convert.ToDecimal(1.3);
            }
            return this.DailyRate.Amount;
        }
        public void DeleteRoom(string nameOfRoomToDelete)
        {
            foreach (var roomToDelete in lstRooms)
            {
                if (nameOfRoomToDelete == roomToDelete.Name)
                {
                    lstRooms.Remove(roomToDelete);
                }
            }
        }
        public void Print()
        {
            Console.WriteLine($"\t Room {Name}");
            Console.WriteLine($"\t\t Adults: {Adults}, Children: {Children}");
            this.DailyRate.Print();

            Console.WriteLine($"\t\t After calculation: {this.GetPrice()} {this.DailyRate.Currency}");
        }
    }
}
