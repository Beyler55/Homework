namespace constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Arif","Hasanov",19){};
            
            System.Console.WriteLine(person.IsAdult);
    }
}
}
