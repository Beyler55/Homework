using System;
namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new Student("Vusal", "Musayev", "vusaloo", "vusal2002",80);
            User user2 = new Student("Anar","Guliyev","anarguli","guliyev22",70 );
            User user3 = new Student("Ulvi","Mammadov","mammadov233","mulvi5535",75);

            User[] users = { user1, user2, user3 };
            Console.WriteLine("Please enter the username:");
            string getName = Console.ReadLine();
            Console.WriteLine("Please enter the password:");
            string getPass = Console.ReadLine();
            
            foreach (var item in users)
            {
                if(item.Username==getName && item.Password==getPass)
                {
                    item.GetData();
                    
                }
            }
        }
    }
}
