#pragma warning disable 693
namespace LinearDS.LinkedLists
{
    using System;

    public class MyLinkedList<T>
    {
        #region Node Class

        private class MyNode<T>
        {
            public T _value;

            public MyNode<T> _address;

            public MyNode(T value)
            {
                this._value = value;
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
                node._address = _head;
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
                _tail._address = node;
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
                if (current._value.Equals(value))
                    return index;
                else
                {
                    current = current._address;
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
                _head = current._address;
                current._address = null;
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
                prev._address = null;
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
                arr[index++] = current._value;
                current = current._address;
            }

            return arr;
        }

        public void Reverse()
        {
            if (IsEmpty())
                return;

            var previous = _head;
            var current = _head._address;

            while (current != null)
            {
                var next = current._address;
                current._address = previous;
                previous = current;
                current = next;
            }

            _tail = _head;
            _tail._address = null;
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
                second = second._address;
                if (second == null)
                    throw new ArgumentOutOfRangeException();
            }

            while (second != _tail)
            {
                first = first._address;
                second = second._address;
            }

            return first._value;
        }

        private MyNode<T> GetPreviousToLast()
        {
            var current = _head;

            while (current != null)
            {
                if (current._address == _tail)
                {
                    return current;
                }

                current = current._address;
            }

            return null;
        }

        private bool IsEmpty()
        {
            return _head == null;
        }
    }
}
