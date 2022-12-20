using System.Collections;

namespace Solid
{
    class Solution
    {
        //https://leetcode.com/problems/sqrtx/
        static void Main()
        {
            int n10 = int.Parse(Console.ReadLine());
            //BitArray ba = new BitArray(new int[1] { n10,});
            //Console.WriteLine(Convert.ToString(n10, 2));
            
            //Console.WriteLine(MySqrt(s));

        }
        public static int MySqrt(int x)
        {
            string result = "";
            string n2 = Convert.ToString(x, 2);
            n2 = n2.Length % 2 != 0 ? "0" + n2 : n2; //для того, чтобы можно было разделить по 2 бита

            for (int i = 0; i < n2.Length/2; i++)
            {
                
            }

            




            
            return Convert.ToInt32(result, 10);
        }
    }
}
