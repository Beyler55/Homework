using System;

namespace chararraystr
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] array = { "Akif", "Rahim", "Sirac", "alma" };
            CharInStringArray(array, 'm');
           
        }
        static void CharInStringArray(string[]arr,char ch)
        {
            foreach (var item in arr)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (item[i] == ch)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }
    }
}
