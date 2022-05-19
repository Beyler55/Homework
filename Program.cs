using System;
namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1,2,2,3,3,3 };
            int maincounter = 1;
            int mostusednumber = 0;
            

            for (int i = 0; i < (array.Length - 1); i++)
            {
                int subnumber = array[i];
                int subcounter = 0;

                for (int j = 0; j < array.Length; j++)
                {
                    if (subnumber == array[j])
                    {
                        subcounter++;
                    }
                }

                if (subcounter > maincounter)
                {
                    mostusednumber = subnumber;
                    maincounter = subcounter;
                }
            }

            Console.WriteLine(mostusednumber);
        }
    }
}

