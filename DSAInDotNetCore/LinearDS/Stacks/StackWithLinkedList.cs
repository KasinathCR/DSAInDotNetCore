namespace LinearDS.Stacks
{
    using System;
    using System.Text;

    public class StackWithLinkedList<T>
    {
        private class MyNode<TS>
        {
            public readonly TS Value;

            public MyNode<TS> Next;

            public MyNode(TS value)
            {
                this.Value = value;
            }
        }

        private const int Length = 5;

        private MyNode<T> _top;

        private int _count;

        public void Push(T item)
        {
            if (this._count == Length)
                throw new StackOverflowException();

            var node = new MyNode<T>(item);

            if (this.IsEmpty())
                this._top = node;
            else
            {
                node.Next = this._top;
                this._top = node;
            }

            this._count++;
        }

        public T Pop()
        {
            if (this.IsEmpty())
                throw new InvalidOperationException();

            var value = this._top.Value;
            if (this._count == 1)
                this._top = null;
            else
            {
                var node = this._top.Next;
                this._top.Next = null;
                this._top = node;
            }

            this._count--;

            return value;
        }

        public T Peek()
        {
            if (this.IsEmpty())
                throw new InvalidOperationException();

            return this._top.Value;
        }

        private bool IsEmpty()
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
                str.Append(node.Value);
                str.Append(" ");
                node = node.Next;
            }

            return str.ToString();
        }
    }
}