namespace LinearDS.Stacks
{
    using System.Collections.Generic;

    public class ExpressionBalancer
    {
        private readonly List<char> leftBrackets = new List<char>() { '(', '[', '<', '{' };

        private readonly List<char> rightBrackets = new List<char>() { ')', ']', '>', '}' };

        public bool IsExpressionBalanced(string input)
        {
            var stack = new Stack<char>();

            foreach (var item in input)
            {
                if (IsLeftBrackets(item))
                    stack.Push(item);

                if (!this.IsRightBrackets(item)) continue;
                if (!stack.TryPeek(out var ch))
                    return false;
                var top = stack.Pop();
                if (!this.BracketsMatch(top, item))
                    return false;
            }

            return !stack.TryPeek(out var result);
        }

        private bool IsLeftBrackets(char ch)
        {
            return this.leftBrackets.Contains(ch);
        }

        private bool IsRightBrackets(char ch)
        {
            return this.rightBrackets.Contains(ch);
        }

        private bool BracketsMatch(char left, char right)
        {
            return this.leftBrackets.IndexOf(left) == this.rightBrackets.IndexOf(right);
        }
    }
}