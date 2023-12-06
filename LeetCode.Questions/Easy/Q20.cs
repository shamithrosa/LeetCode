using System.Collections.Generic;

namespace LeetCode.Questions.Easy
{
    /// <summary>
    /// Use a stack of characters.
    /// 
    /// When you encounter an opening bracket, push it to the top of the stack.
    /// 
    /// When you encounter a closing bracket, check if the top of the stack was the opening for it. If yes, pop it from the stack. Otherwise, return false.
    /// </summary>
    public class Q20
    {
        public bool IsValidParentheses(string str)
        {
            Stack<char> parenthesisStack = new Stack<char>();

            foreach (var item in str)
            {
                if (IsOpenBracket(item))
                {
                    parenthesisStack.Push(item);
                }
                else
                {
                    if (parenthesisStack.Count == 0 || !IsMatchingPair(parenthesisStack.Pop(), item))
                    {
                        return false;
                    }
                }
            }

            return parenthesisStack.Count == 0;
        }

        private bool IsOpenBracket(char bracket)
        {
            return bracket == '(' || bracket == '[' || bracket == '{';
        }

        private bool IsMatchingPair(char openBracket, char closingBracket)
        {
            return openBracket.Equals('(') && closingBracket.Equals(')') ||
                openBracket.Equals('[') && closingBracket.Equals(']') ||
                openBracket.Equals('{') && closingBracket.Equals('}');
        }
    }
}
