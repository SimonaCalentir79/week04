using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main()
        {
            var coada = new Queue();
            coada.CreateQueue();
            coada.Print();

            coada.Dequeue();
            Console.WriteLine("\n\t First removed:");
            coada.Print();

            coada.Enqueue();
            Console.WriteLine("\n\t Last added:");
            coada.Print();

            Console.ReadLine();
        }
    }
}
