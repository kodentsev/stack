using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    class Program
    {
        class Stack<T>
        {
            private T[] _array;

            private const int defCapacity = 10;

            private int size;

            public Stack()
            {

            }

            public int SIZE
            {
                get { return 0; }
                set { }
            }

        }

        class Queue<T>
        {
            private T[] _array;

            private int Capacity;

            int head;

            int tail;

            int size;

            public Queue()
            {

            }

            public int SIZE
            {
                get { return 0;  }
                set { }
            }
            

        }

        static void Main(string[] args)
        {

        }
    }
}
