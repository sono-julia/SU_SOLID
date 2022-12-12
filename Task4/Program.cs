namespace Solid
{
    class Solution
    {
        //https://leetcode.com/problems/letter-combinations-of-a-phone-number/

        private readonly static string[] map = new string[10] { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
        static void Main()
        {
            string number = Console.ReadLine();
            IList<string> list = GetCombinations(number);
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
        static IList<string> GetCombinations(string number)
        {
            //Убрать цифры без букв (может с where можно было)
            string filter = number.Replace("0", "").Replace("1", "");
            //количество итоговых комбинаций
            //int count = filter.Select(x => map[int.Parse(x.ToString())].Length).ToList().Aggregate((x, y) => x * y);
            //string[] result = new string[count];
            //IList<string> result;
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(""); //Добавить элемент в очередь

            for (int i = 0; i < filter.Length; i++)
            {
                int index = int.Parse(filter[i].ToString());

                while (queue.Peek().Length == i)
                {
                    string myString = queue.Dequeue();
                    foreach (char c in map[index])
                    {
                        queue.Enqueue(myString + c);
                    }
                }
            }
            //result = queue.ToList();
            return queue.ToList();
        }
    }
}