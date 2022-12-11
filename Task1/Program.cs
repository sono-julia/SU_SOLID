namespace Solid
{
    class Solution
    {
        //https://leetcode.com/problems/palindrome-number/
        static void Main()
        {
            string testPalindrom = Console.ReadLine();
            Console.WriteLine(IsPalindrom(testPalindrom).ToString());
        }
        /// <summary>
        /// Является ли строка палиндромом.
        /// </summary>
        /// <param name="str">Строка для проверки.</param>
        /// <returns></returns>
        static bool IsPalindrom(string str)
        {
            bool test = true;
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                test = str[i] == str[j];
                if (!test) { break; }
            }
            return test;
        }
        static bool IsPalindrom(int x)
        {
            string str = x.ToString();
            bool test = true;
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                test = str[i] == str[j];
                if (!test) { break; }
            }
            return test;
        }
    }
}