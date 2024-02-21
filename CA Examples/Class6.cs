using System.Numerics;

namespace CA_Examples
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enrter two numbers: ");
            int num1=Convert.ToInt32(Console.ReadLine());
            int num2=Convert.ToInt32(Console.ReadLine());
        Operator:
            Console.WriteLine("Enter Operator");
            char op=Convert.ToChar(Console.ReadLine());
            int res = 0;
            switch(op)
            {
                case '+':
                    res=num1 + num2;
                    break;
                case '-':
                    res=num1 - num2;
                    break;
                case '*':
                    res=num1 * num2;
                    break;
                 case '/':
                    res=num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid Operator");
                    goto Operator;

            }
            Console.WriteLine("Result is: " + res);

        }
    }
}
