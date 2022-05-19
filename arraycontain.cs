using System;

namespace arrtask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstarray = { 1, 2, 3, 4, 5 };
            int[] secondarray = { 2, 3 };
            Console.WriteLine(IsArrayContains(firstarray, secondarray));
        }


        static bool IsArrayContains(int[] arr1, int[] arr2)
        {
            int number1 = 0;

            for (int a = 0; a < arr1.Length; a++)
            {
                number1 = number1 * 10;
                number1 += arr1[a];
            }


            int number2 = 0;

            for (int b = 0; b < arr2.Length; b++)
            {
                number2 = number2 * 10;
                number2 += arr2[b];
            }

            return number1.ToString().Contains(number2.ToString());
        }
    }
}
