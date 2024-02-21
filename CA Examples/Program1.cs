using System.ComponentModel.Design;

namespace CA_Examples
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Age: ");
            short age = Convert.ToInt16(Console.ReadLine());

            //Simple if 

            if(age >= 18 )
            {
                Console.WriteLine("You are Eligible to vote.");
            }
        }
    }
}
