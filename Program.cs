using System;

public class Program
{

    //Task - 1
    //IsPrime metodu - parametr olaraq integer value qəbul edir.
    //Göndərilmiş integer dəyərin sadə olub olmadığını qaytarır.
    //Ədəd sadədirsə true, deyilsə false qayıtmalıdır
    public static void Main()
    {
        IsPrime(1);
    }
    public static void IsPrime(int number)
    {
        bool result = true;
        int counter = 0;
        if (number <= 1)
        {
            Console.WriteLine("This number is neither prime nor complex");
        }
        else
        {
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine();
                    counter++;
                    if (counter > 2)
                    {
                        result = false;
                    }
                    break;
                }
            }
            Console.WriteLine(result);
        }
    }
}
