using System;

namespace Methodtask2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task - 2
            //CalcAvg metodu -Göndərilmiş imtahanlar qiyməti siyahısına(integer array) əsasən
            //həmin qiymətlərin ortalamasını qaytaran metod yazın.Main metodunda bu metodu call edib,
            //burdan qayıdan dəyərə əsasən ortalama 60 - dan böyükdürsə console-da "məzun oldunuz"
            //əks halda "məzun ola bilmədiniz" yazısı yazdırın
            int[] arr = { 70, 70, 70, 200 };
            CalcAvg(arr);
            if (CalcAvg(arr) > 60)
            {
                Console.WriteLine("You have graduate");
            }
            else
            {
                Console.WriteLine("You couldn't graduate");
            }
        }
        static int CalcAvg(int[] arr)
        {
            int sum = 0;
            int counter = 0;
            foreach (int item in arr)
            {
                sum = sum + item;
                counter++;
            }
            int average = sum / counter;
            return average;
        }
    }
}
