namespace LinearDS.Stacks
{
    using System;
    using System.Text;

    public class StackWithLinkedList<T>
    {
        private class MyNode<S>
        {
            public readonly S _value;

            public MyNode<S> _next;

            public MyNode(S value)
            {
                this._value = value;
            }
        }

        private const int _length = 5;

        private MyNode<T> _top;

        private int _count;

        public void Push(T item)
        {
            if (this._count == _length)
                throw new StackOverflowException();

            var node = new MyNode<T>(item);

            if (this.IsEmpty())
                this._top = node;
            else
            {
                node._next = this._top;
                this._top = node;
            }

            this._count++;
        }

        public T Pop()
        {
            if (this.IsEmpty())
                throw new InvalidOperationException();

            var value = this._top._value;
            if (this._count == 1)
                this._top = null;
            else
            {
                var node = this._top._next;
                this._top._next = null;
                this._top = node;
            }

            this._count--;

            return value;
        }

        public T Peek()
        {
            if (this.IsEmpty())
                throw new InvalidOperationException();

            return this._top._value;
        }

        public bool IsEmpty()
        {
            return this._top == null;
        }

        public override string ToString()
        {
            if (this.IsEmpty())
                return "The Stack is Empty";

            var str = new StringBuilder();
            var node = this._top;

            while (node != null)
            {
                str.Append(node._value);
                str.Append(" ");
                node = node._next;
            }

            return str.ToString();
        }
    }
}