using System;
namespace Param
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintPyramida(5);
        }

        static void PrintPyramida(int width)
        {
            for (int i = 1; i <= width; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
