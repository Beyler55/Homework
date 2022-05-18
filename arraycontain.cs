using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstarr = { 1, 2, 3, 4, 5, 6 };
            int[] secondarr = { 3, 5 };
            Console.WriteLine(IsArrayContains(firstarr,secondarr));
        }

        static bool IsArrayContains(int[] firstarr,int[] secondarr)
        {
            string str1 = string.Join(' ', firstarr);
            string str2 = string.Join(' ', secondarr);
            return str1.Contains(str2);        
        }
    }
}
