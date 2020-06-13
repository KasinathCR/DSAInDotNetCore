using System;
using System.Collections.Generic;
using System.Text;
#pragma warning disable 649

namespace LinearDS.LinkedLists
{
    public class MyDoublyLinkedList<T>
    {
        #region Node

        private class MyNode<T>
        {
            public T _value;

            public MyNode<T> _previous;

            public MyNode<T> _next;

            public MyNode(T value)
            {
                this._value = value;
            }
        }

        #endregion

        private MyNode<T> _head;

        private MyNode<T> _tail;

        private int size;

        public void AddHead(T value)
        {
            var node = new MyNode<T>(value);

            if (this.IsEmpty())
                this._head = this._tail = node;
            else
            {
                node._next = this._head;
                node._previous = null;
                this._head._previous = node;
                this._head = node;
            }

            this.size++;
        }

        public void AddTail(T value)
        {
            var node = new MyNode<T>(value);

            if (this.IsEmpty())
                this._head = this._tail = node;
            else
            {
                node._next = null;
                node._previous = this._tail;
                this._tail._next = node;
                this._tail = node;
            }

            this.size++;
        }

        public void RemoveHead()
        {
            if (this.IsEmpty())
                throw new InvalidOperationException();
            if (this._head == this._tail)
                this._head = this._tail = null;
            else
            {
                var node = this._head._next;
                node._previous = null;
                this._head._next = null;
                this._head = node;
            }

            this.size--;
        }

        public void RemoveTail()
        {
            if (this.IsEmpty())
                throw new InvalidOperationException();
            if (this._head == this._tail)
                this._head = this._tail = null;
            else
            {
                var node = this._tail._previous;
                node._next = null;
                this._tail._previous = null;
                this._tail = node;
            }

            this.size--;
        }

        public int Size()
        {
            return this.size;
        }

        public int IndexOf(T value)
        {
            if (this.IsEmpty())
                throw new InvalidOperationException();
            var node = this._head;
            var index = 0;
            while (node != null)
            {
                index++;
                if (node._value.Equals(value))
                    return index;
                node = node._next;
            }

            return -1;
        }

        public T[] ToArray()
        {
            if (this.IsEmpty())
                throw new InvalidOperationException();
            var node = this._head;
            var index = 0;
            var arr = new T[this.size];
            while (node != null)
            {
                arr[index++] = node._value;
                node = node._next;
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
            var current = previous._next;
            this._head._next = null;
            while (current != null)
            {
                var next = current._next;
                previous._previous = current;
                current._next = previous;
                current._previous = next;
                previous = current;
                current = next;
            }
            this._tail = this._head;
            this._head = previous;
            this._head._previous = null;
        }

        private bool IsEmpty()
        {
            return this._head == null;
        }
    }
}
