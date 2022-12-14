namespace Solid
{
    class Solution
    {
        //https://leetcode.com/problems/valid-parentheses/
        static void Main()
        {
            string s = Console.ReadLine();
            Console.WriteLine(IsValid(s));

        }
        public static bool IsValid(string s)
        {
            Dictionary<char, char> pairs = new Dictionary<char, char>
            {
                { '(',')' },
                { '[', ']' },
                { '{', '}' },
            };
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (pairs.ContainsKey(c))
                { 
                    stack.Push(c);
                } 
                else if (!stack.Any())
                {
                    return false;
                }
                else if (c == pairs[stack.Peek()])
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
            return !stack.Any();
        }
    }
}