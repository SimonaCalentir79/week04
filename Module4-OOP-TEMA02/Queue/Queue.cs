using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Queue
    {
        private SortedList<int,int> listaVal = new SortedList<int,int>();

        public void CreateQueue()
        {
            int x = 10;

            for (int i = 1; i < 11; i++)
            {
                listaVal.Add(i, x);
                x = x + 10;
            }
        }
        public void Enqueue()
        {
            int lastKey, lastVal, x, y;

            lastKey = listaVal.Keys.Last();
            lastVal = listaVal.Values.Last();

            x = lastKey + 1;
            y = lastVal + 10;

            listaVal.Add(x,y);
        }
        public void Dequeue()
        {
            listaVal.RemoveAt(0);
        }

        public void Print()
        {
            Console.WriteLine("\n\t Elements of 'queue' are:");
            foreach (var item in listaVal)
            {
                Console.WriteLine($"\t\t key: {item.Key} -- value: {item.Value}");
            }
        }

    }
}
