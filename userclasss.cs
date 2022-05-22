namespace usercl
{
    class Program
    {
        static void Main(string[] args)
        {
            User developer = new User { Name = "Faiq", Password = "Fa11122" };
            System.Console.WriteLine(developer.IsPasswordValid());
        }
    }

    class User
    {
        public string Name;
        public string Password;

        public bool IsPasswordValid()
        {
         
            int i = 0, j = 0;
            if (Password.Length > 6)
            {
               
                while (i < Password.Length && j < Name.Length)
                {
                    if (Password[i] == Name[j])
                    {

                        i++;
                        j++;


                        if (j == Name.Length)
                            return false;
                    }

                    else
                    {
                        i = i - j + 1;
                        j = 0;
                    }


                }
                return true;

            }

            else
            {
                return false; ;
            }

        }


    }
}


