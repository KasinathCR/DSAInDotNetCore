#pragma warning disable 693
namespace LinearDS.LinkedLists
{
    using System;

    public class MyLinkedList<T>
    {
        #region Node Class

        private class MyNode<T>
        {
            public T Value;

            public MyNode<T> Address;

            public MyNode(T value)
            {
                this.Value = value;
            }
        }

        #endregion

        private MyNode<T> _head;

        private MyNode<T> _tail;

        private int _size;

        public void AddHead(T value)
        {
            var node = new MyNode<T>(value);

            if (this.IsEmpty()) this._head = _tail = node;
            else
            {
                node.Address = _head;
                _head = node;
            }

            _size++;
        }

        public void AddTail(T value)
        {
            var node = new MyNode<T>(value);

            if (IsEmpty())
                _head = _tail = node;
            else
            {
                _tail.Address = node;
                _tail = node;
            }

            _size++;
        }

        public int IndexOf(T value)
        {
            int index = 0;
            MyNode<T> current = _head;

            while (current != null)
            {
                if (current.Value.Equals(value))
                    return index;
                else
                {
                    current = current.Address;
                    index++;
                }
            }

            return -1;
        }

        public bool Contains(T value)
        {
            return IndexOf(value) != -1;
        }

        public void RemoveHead()
        {
            if (IsEmpty())
                throw new NullReferenceException();
            else if (_head == _tail)
                _head = _tail = null;
            else
            {
                var current = _head;
                _head = current.Address;
                current.Address = null;
            }

            _size--;
        }

        public void RemoveTail()
        {
            if (IsEmpty())
                throw new NullReferenceException();
            else if (_head == _tail)
                _head = _tail = null;
            else
            {
                var prev = this.GetPreviousToLast();
                _tail = prev;
                prev.Address = null;
            }

            _size--;
        }

        public int Size()
        {
            return _size;
        }

        public T[] ToArray()
        {
            var arr = new T[_size];
            var current = _head;
            var index = 0;
            while (current != null)
            {
                arr[index++] = current.Value;
                current = current.Address;
            }

            return arr;
        }

        public void Reverse()
        {
            if (IsEmpty())
                return;

            var previous = _head;
            var current = _head.Address;

            while (current != null)
            {
                var next = current.Address;
                current.Address = previous;
                previous = current;
                current = next;
            }

            _tail = _head;
            _tail.Address = null;
            _head = previous;
        }

        public T FindKthItemFromTail(int k)
        {
            if (IsEmpty())
                throw new ArgumentException();

            var first = _head;
            var second = _head;

            for (var i = 0; i < k - 1; i++)
            {
                second = second.Address;
                if (second == null)
                    throw new ArgumentOutOfRangeException();
            }

            while (second != _tail)
            {
                first = first.Address;
                second = second.Address;
            }

            return first.Value;
        }

        private MyNode<T> GetPreviousToLast()
        {
            var current = _head;

            while (current != null)
            {
                if (current.Address == _tail)
                {
                    return current;
                }

                current = current.Address;
            }

            return null;
        }

        private bool IsEmpty()
        {
            return _head == null;
        }
    }
}
