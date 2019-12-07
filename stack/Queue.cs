using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    class _Queue<T>
    {
        private T[] _array;

        private int Capacity = 1000;

        int head;

        int tail;

        int size;

        public _Queue()
        {
            size = 0;
            head = -1;
            tail = -1;
            _array = new T[Capacity];
        }

        public void CLEAR()
        {
            size = 0;
            head = -1;
            tail = -1;
            _array = new T[Capacity];
        }

        public int SIZE
        {
            get { return size; }
        }

        public bool ISEMPTY()
        {
            return size == 0;
        }

        public bool ISFULL()
        {
            return size == Capacity;
            ;
        }

        public void PUSH(T Item)
        {
            if (ISFULL())
                throw new Exception("Очередь полностью заполнена.");

            _array[++tail] = Item;
            size++;
        }

        public T POP()
        {
            if (ISEMPTY())
                throw new Exception("Очередь не заполнена.");

            T value = _array[++head];
            size--;
            if (head == tail)
            {
                head = -1;
                tail = -1;
            }
            return value;
        }

        public T FRONT()
        {
            if (ISEMPTY())
                throw new Exception("Очередь не заполнена.");

            T value = _array[head++];
            return value;
        }
    }
}
