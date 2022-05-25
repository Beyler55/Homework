using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class User
    {
        public  User()
        {
            
        }

        public string Name;
        public string Surname;
        public string Username;
        public string Password;


        public virtual void GetData()
        {
            Console.WriteLine(Name+" " + Surname+" "+Username+" "+Password+" ");
            
        }
    }
}
