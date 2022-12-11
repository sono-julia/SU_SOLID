namespace Solid
{
    class Solution
    {
        //https://leetcode.com/problems/roman-to-integer/
        static void Main()
        {
            string romanNumber = Console.ReadLine();
            Console.WriteLine(GetNumberFromRome(romanNumber));
        }
        /// <summary>
        /// Получить десятичную запись римского числа.
        /// </summary>
        /// <param name="romanNumber">Римское число.</param>
        /// <returns>Целое число в десятичной записи.</returns>
        static int GetNumberFromRome(string romanNumber)
        {
            int resultNumber = 0;
            Dictionary<char, int> map = new Dictionary<char, int>
            {
                {'I', 1 },
                {'V', 5 },
                {'X', 10 },
                {'L', 50 },
                {'C', 100 },
                {'D', 500 },
                {'M', 1000 },
            };
            int temp = map[romanNumber.First()];
            bool firstStep = true;
            foreach (char nRome in romanNumber)
            {
                if (firstStep)
                {
                    firstStep = false;
                }
                else
                {
                    int curNumber = map[nRome];
                    if (curNumber > temp)
                    {
                        resultNumber -= temp;
                    }
                    else
                    {
                        resultNumber += temp;
                    }
                    temp = curNumber;
                }
            }
            return resultNumber + temp;
        }
    }
}