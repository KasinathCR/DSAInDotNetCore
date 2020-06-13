namespace LinearDS.Stacks
{
    using System.Collections.Generic;
    using System.Text;

    public class StringReverser
    {
        public string ReverseString(string input)
        {
            var reversedString = new StringBuilder();
            var stack = new Stack<char>();
            foreach (var item in input)
            {
                stack.Push(item);
            }

            while (stack.TryPop(out var ch))
            {
                reversedString.Append(ch);
            }

            return reversedString.ToString();
        }
    }
}