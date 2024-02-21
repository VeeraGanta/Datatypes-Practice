namespace My_first_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C#.Net");
            Console.WriteLine("Enter your Name:");
            //int Name= Console.Read();
            string Name=Console.ReadLine();
            Console.WriteLine("Welcome Mr/Mrs" + Name);

        }
    }
}
