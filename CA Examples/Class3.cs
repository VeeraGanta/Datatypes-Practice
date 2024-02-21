using System.ComponentModel.Design;

namespace CA_Examples
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Username");
            string uname = Console.ReadLine();
            if (uname =="admin@gmail.com")
            {
                Console.WriteLine("Enter Password");
                string pwd = Console.ReadLine();
                if(pwd =="admin@123")
                {
                    Console.WriteLine("Login Sucess");
                }
                else
                {
                    Console.WriteLine("Password Invalid");
                }
            }
            else
            {
                Console.WriteLine("User Invalid");
            }
        }
    }
}
