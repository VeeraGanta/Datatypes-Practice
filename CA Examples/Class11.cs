

namespace CA_Examples
{
    internal class Class11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Palindrome number");
            int number = int.Parse(Console.ReadLine());
            int remainder, sum = 0;
            int temp = number;
            while (number > 0) 
            {
                remainder = number % 10;

                sum = (sum * 10) + remainder;
                number = number / 10;
            }
            if (temp==sum)
            {
                Console.WriteLine($"Number {temp} is a palindrome");
            }
            else
            {
                Console.WriteLine($"Number {temp} is not a palindrome");
            }
            Console.ReadKey();
        }
    }
}
