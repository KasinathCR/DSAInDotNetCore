namespace LinearDS.Stacks
{
    using System;
    using System.Linq;
    using System.Text;

    public class StackWithArrays<T>
    {
        private readonly T[] _stack = new T[5];

        private int _count;

        public T[] Push(T item)
        {
            if (this._count == this._stack.Length)
                throw new StackOverflowException();

            this._stack[this._count++] = item;
            return this._stack;
        }

        public T Pop()
        {
            if (this._count == 0)
                throw new InvalidOperationException();

            return this._stack[--this._count];
        }

        public T Peek()
        {
            return this._stack[this._count - 1];
        }

        public override string ToString()
        {
            var str = new StringBuilder();
            var newArr = new T[this._count];

            Array.ConstrainedCopy(this._stack, 0, newArr, 0, this._count);

            foreach (var item in newArr.AsParallel())
            {
                str.Append(item);
                str.Append(" ");
            }

            return str.ToString();
        }

        public bool IsEmpty()
        {
            return this._count == 0;
        }
    }
}