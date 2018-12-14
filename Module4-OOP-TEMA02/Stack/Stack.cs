using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack
    {
        private SortedList<int, int> listaVal = new SortedList<int, int>();

        public void CreateStack()
        {
            int x = 10;
            for (int i = 1; i < 11; i++)
            {
                listaVal.Add(i,x);
                x = x + 10;
            }
        }
        public void Push()
        {
            int lastKey, lastVal, x, y;

            lastKey = listaVal.Keys.Last();
            lastVal = listaVal.Values.Last();

            x = lastKey + 1;
            y = lastVal + 10;

            listaVal.Add(x,y);

        }
        public void Pop()
        {
            int lastKey = 0;

            lastKey = listaVal.Keys.Last();

            listaVal.Remove(lastKey);
        }
        public void Print()
        {
            Console.WriteLine("\n\t Elements of 'STACK' are: ");
            foreach (var item in listaVal)
                Console.WriteLine($"\t\t key: {item.Key} -- value: {item.Value}");
        }
    }
}
