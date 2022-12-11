namespace Solid
{
    class Solution
    {
        //https://leetcode.com/problems/two-sum/
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
            int goalNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(GetIndexesOfNumbers(numbers, goalNumber));
        }
        /// <summary>
        /// Получить индексы двух чисел, сумма которых равна заданному числу.
        /// </summary>
        /// <param name="numbers">Список чисел.</param>
        /// <param name="goalNumber">Требуемая сумма.</param>
        /// <returns>Возвращает два индекса чисел.</returns>
        private static int[] GetIndexesOfNumbers(int[] numbers, int goalNumber)
        {
            int[] result = new int[2];
            int count = numbers.Length;
            for (int i = 0, j = 1; i < count && j < count+1; j++)
            {
                if (numbers[i] + numbers[j] == goalNumber) 
                {
                    result[0] = i; result[1] = j;
                    return result ; 
                }
                else if ( j == count -1) { i++; j = 1;}
            }
            return result;
        }
    }
}