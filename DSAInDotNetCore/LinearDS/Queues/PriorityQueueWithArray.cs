using System;
using System.Text;

namespace LinearDS.Queues
{
    public class PriorityQueueWithArray
    {
        private readonly int[] _items;
        private readonly int _length;

        private int _count;

        private int _first;

        private int _last;

        public PriorityQueueWithArray(int length)
        {
            _length = length;
            _items = new int[length];
        }

        public void Enqueue(int item)
        {
            if (IsFull())
            {
                Console.WriteLine("The Priority Queue is Full!");
            }
            else
            {
                if (IsEmpty())
                    _items[_last] = item;
                else
                    for (var i = _last - 1; i >= _first; i--)
                        if (item < _items[i])
                        {
                            _items[i + 1] = _items[i];
                        }
                        else
                        {
                            _items[i + 1] = item;
                            break;
                        }

                _last = (_last + 1) % _items.Length;
                _count++;
                Console.WriteLine($"Item {item} inserted to Queue");
            }
        }

        public override string ToString()
        {
            var str = new StringBuilder();
            if (IsEmpty())
            {
                str.Append("The Priority Queue is Empty");
            }
            else
            {
                str.Append("The Items in the Priority Queue are:\n");
                for (var i = _first; i < _count; i++) str.Append(_items[i] + "\n");
            }

            return str.ToString();
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

        private bool IsFull()
        {
            return _count == _length;
        }

        private bool IsEmpty()
        {
            return _count == 0;
        }
    }
}