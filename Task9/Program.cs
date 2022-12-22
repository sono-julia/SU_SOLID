using System.Collections;

namespace Solid
{
    class Solution
    {
        //https://leetcode.com/problems/sqrtx/
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            //BitArray ba = new BitArray(new int[1] { n,});
            //Console.WriteLine(Convert.ToString(n, 2));
            
            Console.WriteLine(MySqrt(n));

        }
        public static int MySqrt(int x)
        {
            string result = "";
            string n2 = Convert.ToString(x, 2);
            n2 = n2.Length % 2 != 0 ? "0" + n2 : n2; //для того, чтобы можно было разделить по 2 бита

            for (int i = 0; i < n2.Length/2; i++)
            {
                int square = (int)Math.Pow(Convert.ToInt32(result + "1", 2), 2);
                string substring = n2.Substring(0, (i + 1) * 2);
                if (square <= Convert.ToInt32(substring, 2))
                {
                    result += "1";
                }
                else
                {
                    result += "0";
                }
            }
            return Convert.ToInt32(result, 2);
        }
    }
}
