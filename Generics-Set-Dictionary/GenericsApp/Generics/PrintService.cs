﻿
namespace Generics
{
    
    class PrintService
    { 
        private int[] _values = new int[10];
        private int _count = 0;

        public void addValue(int value)
        {
            if(_count == _values.Length)
            {
                throw new InvalidOperationException("PrintService is full");
            }

            _values[_count++] = value;
        }

        public int First()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("PrintService is empty");
            }
            return _values[0];
        }

        public void Print()
        {
            Console.Write("[");

            for(int i = 0; i < _count -1; i++)
            {
                Console.Write(_values[i] + ", ");
            }

            if(_count > 0)
            {
                Console.Write(_values[_count - 1]);
            }

            Console.WriteLine("]");
        }
    }
}
