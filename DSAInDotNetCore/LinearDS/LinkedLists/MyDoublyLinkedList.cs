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

        private bool IsEmpty()
        {
            return this._head == null;
        }
    }
}
