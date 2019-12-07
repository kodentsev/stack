using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    class _Stack<T>
    {
        private T[] _array;

        private const int defCapacity = 10;

        private int size;

        public _Stack()
        {
            size = 0;
            _array = new T[defCapacity];
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
            return size == defCapacity;
        }

        public void PUSH(T Element)
        {
            if (ISFULL())
                throw new Exception("Стэк полностью заполнен.");

            _array[size++] = Element;
        }

        public T PEEK()
        {
            if (ISEMPTY())
                throw new Exception("Стэк не заполнен.");
            return _array[size--];
        }

        public T POP()
        {
            if (ISEMPTY())
                throw new Exception("Стэк не заполнен.");
            return _array[--size];
        }

        public void CLEAR()
        {
            this.size = 0;
            this._array = new T[defCapacity];
        }
    }
}
