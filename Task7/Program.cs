namespace Solid
{
    class Solution
    {
        //https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/
        static void Main()
        {
            int[] s = Console.ReadLine().Split().Select(n=>int.Parse(n)).OrderBy(n=>n).ToArray();
            //Console.WriteLine(String.Join(" ", s));
            Console.WriteLine(string.Join(" ",FindDisappearedNumbers(s)));
        }


        //226 ms
        public static IList<int> FindDisappearedNumbers_(int[] nums)
        {
            int length = nums.Length;
            HashSet<int> unique = nums.ToHashSet();
            IEnumerable<int> indexes = Enumerable.Range(1, length);
            List<int> res = indexes.Except(unique).ToList();
            return res;
        }

        //147 ms
        public static IList<int> FindDisappearedNumbers(int[] nums)
        {
            Array.Sort(nums);
            int length = nums.Length;
            List<int> res = new List<int>();
            nums.Distinct();

            for (int i = 1; i <= length; i++)
            {
                if (!nums.Contains(i))
                {
                    res.Add(i);
                }
            }
            return res;
        }
    }
}
