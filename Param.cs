using System;
namespace Param
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfElem(1, 2, 3, 4));
        }

        static bool SumOfElem(params int[] arr)
        {
            bool value = false;
            int sum = 0;
            foreach (int elem in arr)
            {
                sum += elem;
            }

            if (sum % 2 == 0)
            {
                value = true;
                return value;
            }
            return value;
        }

    }
}
