using System;

namespace LinearDS.Arrays
{
    public class MyArray<T>
    {
        private T[] _arr;
        private int _count;

        public MyArray(int length)
        {
            _arr = new T[length];
        }

        //Run-time Complexity = O(n)
        public void Insert(T item)
        {
            if (_arr.Length == _count)
            {
                var newArr = new T[2 * _count];

                for (var i = 0; i < _count; i++)
                    newArr[i] = _arr[i];

                _arr = newArr;
            }

            _arr[_count++] = item;
        }

        //Run-time Complexity = O(n)
        public void Print()
        {
            for (var i = 0; i < _count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }

        //Run-time Complexity = O(n)
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= _count)
                throw new ArgumentOutOfRangeException();

            for (var i = index; i < _count - 1; i++)
            {
                _arr[i] = _arr[i + 1];
            }

            _count--;
        }

        //Run-time Complexity = O(n)
        public int IndexOf(T item)
        {
            var index = -1;

            for (var i = 0; i < _count; i++)
            {
                if (_arr[i].Equals(item))
                {
                    index = i;
                }
            }

            return index;
        }
    }
}
