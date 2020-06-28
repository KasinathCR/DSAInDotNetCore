#pragma warning disable 693
#pragma warning disable 649

namespace LinearDS.LinkedLists
{
    using System;

    public class MyDoublyLinkedList<T>
    {
        #region Node

        private class MyNode<T>
        {
            public T Value;

            public MyNode<T> Previous;

            public MyNode<T> Next;

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

            if (this.IsEmpty())
                this._head = this._tail = node;
            else
            {
                node.Next = this._head;
                node.Previous = null;
                this._head.Previous = node;
                this._head = node;
            }

            this._size++;
        }

        public void AddTail(T value)
        {
            var node = new MyNode<T>(value);

            if (this.IsEmpty())
                this._head = this._tail = node;
            else
            {
                node.Next = null;
                node.Previous = this._tail;
                this._tail.Next = node;
                this._tail = node;
            }

            this._size++;
        }

        public void RemoveHead()
        {
            if (this.IsEmpty())
                throw new InvalidOperationException();
            if (this._head == this._tail)
                this._head = this._tail = null;
            else
            {
                var node = this._head.Next;
                node.Previous = null;
                this._head.Next = null;
                this._head = node;
            }

            this._size--;
        }

        public void RemoveTail()
        {
            if (this.IsEmpty())
                throw new InvalidOperationException();
            if (this._head == this._tail)
                this._head = this._tail = null;
            else
            {
                var node = this._tail.Previous;
                node.Next = null;
                this._tail.Previous = null;
                this._tail = node;
            }

            this._size--;
        }

        public int Size()
        {
            return this._size;
        }

        private int IndexOf(T value)
        {
            if (this.IsEmpty())
                throw new InvalidOperationException();
            var node = this._head;
            var index = 0;
            while (node != null)
            {
                index++;
                if (node.Value.Equals(value))
                    return index;
                node = node.Next;
            }

            return -1;
        }

        public T[] ToArray()
        {
            if (this.IsEmpty())
                throw new InvalidOperationException();
            var node = this._head;
            var index = 0;
            var arr = new T[this._size];
            while (node != null)
            {
                arr[index++] = node.Value;
                node = node.Next;
            }

            return arr;
        }

        public bool Contains(T value)
        {
            return IndexOf(value) != -1;
        }

        public void Reverse()
        {
            if (this.IsEmpty())
                return;
            var previous = this._head;
            var current = previous.Next;
            this._head.Next = null;
            while (current != null)
            {
                var next = current.Next;
                previous.Previous = current;
                current.Next = previous;
                current.Previous = next;
                previous = current;
                current = next;
            }

            this._tail = this._head;
            this._head = previous;
            this._head.Previous = null;
        }

        public T FindKthElementFromTail(int k)
        {
            if (this.IsEmpty())
                throw new InvalidOperationException();

            var first = this._head;
            var second = this._head;

            for (var i = 0; i < k - 1; i++)
            {
                second = second.Next;
                if (second == null)
                    throw new InvalidOperationException();
            }

            while (second != this._tail)
            {
                first = first.Next;
                second = second.Next;
            }

            return first.Value;
        }

        private bool IsEmpty()
        {
            return this._head == null;
        }
    }
}
