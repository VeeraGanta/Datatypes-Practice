

namespace CA_Examples
{
    class CAExample2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Username: ");
            string uname = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string pwd= Console.ReadLine();
            if (uname == "admin@gmail.com" && pwd == "admin@123")
            {
                Console.WriteLine("Login Sucess");
            }

            else
            {
                Console.WriteLine("Invalid Credentials");
            }
            
        }
    }
}
