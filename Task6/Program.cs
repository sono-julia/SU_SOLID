namespace Solid
{
    class Solution
    {
        //https://leetcode.com/problems/is-subsequence/solutions/
        static void Main()
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            Console.WriteLine(s);
        }

        static bool IsSubstring(string s, string t)
        {
            int i = 0;
            foreach (char c in t)
            {
                if (c.Equals(s[i]))
                {
                    i++;
                }
                if (i == s.Length)
                {
                    return true;
                }
            }
            return false;
        }
    }
}