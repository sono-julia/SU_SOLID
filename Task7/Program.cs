namespace Solid
{
    class Solution
    {
        //https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/
        static void Main()
        {
            int[] s = Console.ReadLine().Split().Select(n=>int.Parse(n)).OrderBy(n=>n).ToArray();
            Console.WriteLine(String.Join(" ", s));
            
        }

        //public IList<int> FindDisappearedNumbers(int[] nums)
        //{
            
        //}
    }
}
