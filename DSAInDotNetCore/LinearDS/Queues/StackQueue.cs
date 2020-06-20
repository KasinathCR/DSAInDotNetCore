using System;
using System.Collections.Generic;
using System.Text;

namespace LinearDS.Queues
{
    public class StackQueue<T>
    {
        private readonly Stack<T> _initialStack;

        private readonly Stack<T> _finalStack;

        private int _count;

        private readonly int _length;

        public StackQueue(int length)
        {
            _length = length;
            _initialStack = new Stack<T>(length);
            _finalStack = new Stack<T>(length);
        }

        public void Enqueue(T item)
        {
            if (IsFull())
                Console.WriteLine("Queue is Full!");
            else
            {
                if (!_finalStack.TryPeek(out _))
                    _finalStack.Push(item);

                else
                {
                    while (_finalStack.TryPop(out var result))
                    {
                        _initialStack.Push(result);
                    }

                    _finalStack.Push(item);

                    while (_initialStack.TryPop(out var result))
                    {
                        _finalStack.Push(result);
                    }
                }

                Console.WriteLine($"{item} added to Queue!");
                _count++;
            }
        }

        public void Dequeue()
        {
            if (IsEmpty())
                Console.WriteLine("Queue is Empty!");
            else
            {
                var item = _finalStack.Pop();
                Console.WriteLine($"{item} is removed from Queue");
                _count--;
            }
        }

        public void Peek()
        {
            Console.WriteLine(IsEmpty() ? "Queue is Empty!" : $"The first item in Queue is {_finalStack.Peek()}");
        }

        public override string ToString()
        {
            var str = new StringBuilder();

            if (IsEmpty())
                str.Append("Queue is Empty!");

            else
            {
                var array = _finalStack.ToArray();
                str.Append("The items in the Queue are:\n");
                for (var i = 0; i < array.Length; i++)
                {
                    str.Append(array[i]);
                    if (i != array.Length - 1)
                        str.Append("\n");
                }
            }

            return str.ToString();
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