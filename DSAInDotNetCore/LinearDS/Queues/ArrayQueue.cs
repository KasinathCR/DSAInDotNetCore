using System;
using System.Text;

namespace LinearDS.Queues
{
    public class ArrayQueue<T>
    {
        private readonly T[] _items;

        private int _first;

        private int _last;

        private int _count;

        public ArrayQueue(int length)
        {
            _items = new T[length];
        }

        public void Enqueue(T item)
        {
            if (IsFull())
                Console.WriteLine("Queue is Full");
            else
            {
                _items[_last] = item;
                _last = (_last + 1) % _items.Length;
                _count++;
                Console.WriteLine($"Item {item} inserted to Queue");
            }
        }

        public void Dequeue()
        {
            if (IsEmpty())
            {
                _first = _last = 0;
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Console.WriteLine($"The Dequeued Item is {_items[_first]}");
                _items[_first] = default;
                _first = (_first + 1) % _items.Length;
            }

            _count--;
        }

        public void Peek()
        {
            Console.WriteLine(IsEmpty() ? "Queue is Empty" : $"The First Item in Queue is {_items[_first]}");
        }

        public override string ToString()
        {
            var str = new StringBuilder();

            if (IsEmpty())
                str.Append("Queue is Empty");
            else
            {
                str.Append("The Items in the Queue are:\n");

                for (var i = _first; i < _count; i++)
                {
                    str.Append(_items[i]);
                    if (i != _count - 1)
                        str.Append("\n");
                }
            }

            return str.ToString();
        }

        private bool IsFull()
        {
            return _count == _items.Length;
        }

        private bool IsEmpty()
        {
            return _count == 0;
        }
    }
}