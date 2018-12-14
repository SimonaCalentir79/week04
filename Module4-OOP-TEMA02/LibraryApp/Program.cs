using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    class Program
    {
        static void Main()
        {
            var libr = new Library();
            libr.AddLibrary();

            libr.Print();

            libr.RemoveBook();

            libr.Print();

            Console.ReadLine();
        }
    }
}
