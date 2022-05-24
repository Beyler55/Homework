using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    class Person
    {
        public string Name;
        public string Surname;
        public int Age;
        public bool IsAdult;

        public Person(string name,string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            IsAdult = false;
            if (Age>18)
            {
                IsAdult = true;
            }
        }
    }
}
