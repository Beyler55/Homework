namespace inheritance
{
    class Student : User
    {

        public Student(string name,string surname,string username, string password,  int grade )
        {
            Username = username;
            Surname = surname;
            Password = password;
            Grade = grade;
            Name = name;
        }
        public int Grade;
        public override void GetData()
        {
            System.Console.WriteLine(Grade);
        }
    }
}
