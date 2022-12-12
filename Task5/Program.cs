namespace Solid
{
    class Solution
    {
        //общее начало
        static void Main()
        {
            string[] strings = Console.ReadLine().Split();
            Console.WriteLine(GetCommonSymbols(strings));
        }

        static string GetCommonSymbols(string[] strings)
        {
            strings = strings.Select(s => s.ToLower()).ToArray();
            int minLength = strings.Select(s=>s.Length).ToArray().Min();
            string common = "";
            char temp = ' ';
            //i - порядковый индекс символа, j - порядковый индекс строки
            for (int i = 0, j = 0; i < minLength;)
            {
                if (j == 0)
                {
                    temp = strings[j][i];
                }
                else if (!strings[j][i].Equals(temp))
                {
                    return common;
                }
                j++;

                if (j == strings.Length)
                {
                    common += temp;
                    j = 0;
                    i++;
                }
            }
            return common;
        }
    }
}