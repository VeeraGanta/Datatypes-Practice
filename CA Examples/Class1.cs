

namespace CA_Examples
{
    internal class Class1

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eneter Username: ");
            string uname = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string pwd = Console.ReadLine();
            if (uname == "admin@gmail.com" && pwd == "admin@9122")
            {
                Console.WriteLine("Login sucessful");
                     }
            else
            {
                Console.WriteLine("Login Failed");
            }
        }
    }
}
