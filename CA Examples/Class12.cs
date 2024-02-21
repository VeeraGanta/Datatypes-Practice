
using System.ComponentModel.Design;

namespace CA_Examples
{
    internal class Class12
    {
        static void Main(string[] args)
        {
            int n, r, sum = 0, temp;
            Console.WriteLine("Enter the number");
            n=int.Parse(Console.ReadLine());
            temp = n;
            while(n>0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
            }
            if(temp==sum)
            {
                Console.WriteLine("It is an Amstrong Number");
            }
            else
            {
                Console.WriteLine("It is not an Amstrong Number");
            }
        }
    }
}
