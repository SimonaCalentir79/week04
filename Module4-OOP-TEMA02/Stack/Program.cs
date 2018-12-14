using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main()
        {
            var stack = new Stack();
            stack.CreateStack();
            stack.Print();

            stack.Pop();
            Console.WriteLine("\n\t After POP: ");
            stack.Print();

            stack.Push();
            Console.WriteLine("\n\t After PUSH:");
            stack.Print();

            stack.Push();
            Console.WriteLine("\n\t After PUSH:");
            stack.Print();

            stack.Pop();
            Console.WriteLine("\n\t After POP: ");
            stack.Print();

            Console.ReadLine();
        }
    }
}
