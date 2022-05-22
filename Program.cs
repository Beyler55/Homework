using System;

namespace arraysorttask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 1, 3, 2, 4, 8 };
            CustomSort(array);
        }
        static void CustomSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    int temp = arr[j];
                    if (arr[i] < arr[j])
                    {
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
