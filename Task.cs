using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RevString());
        }
        static string RevString()
        {
            string names = "Nurlan Faiq Emil Tural Yusif";
            string[] spl = names.Split(' ');
            string revname = "";
            string temp = "";
            foreach (var item in spl)
            {

                for (int i = item.Length - 1; i >= 0; i--)
                {
                    revname = revname + item[i];

                }

            }
            return revname;
        }
    }
}
