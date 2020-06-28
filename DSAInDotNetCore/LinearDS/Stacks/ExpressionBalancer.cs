namespace LinearDS.Stacks
{
    using System.Collections.Generic;

    public class ExpressionBalancer
    {
        private readonly List<char> _leftBrackets = new List<char>() { '(', '[', '<', '{' };

        private readonly List<char> _rightBrackets = new List<char>() { ')', ']', '>', '}' };

        public bool IsExpressionBalanced(string input)
        {
            var stack = new Stack<char>();

            foreach (var item in input)
            {
                if (IsLeftBrackets(item))
                    stack.Push(item);

                if (!this.IsRightBrackets(item)) continue;
                if (!stack.TryPeek(out _))
                    return false;
                var top = stack.Pop();
                if (!this.BracketsMatch(top, item))
                    return false;
            }

            return !stack.TryPeek(out _);
        }

        private bool IsLeftBrackets(char ch)
        {
            return this._leftBrackets.Contains(ch);
        }

        private bool IsRightBrackets(char ch)
        {
            return this._rightBrackets.Contains(ch);
        }

        private bool BracketsMatch(char left, char right)
        {
            return this._leftBrackets.IndexOf(left) == this._rightBrackets.IndexOf(right);
        }
    }
}