

using System.Security.Cryptography.X509Certificates;

namespace CA_Examples
{
    internal class Class10
    {
        static void Main(string[] args)
        {
            int num, i, ctr, stno, enno;
            Console.WriteLine("Enter the first number");
            stno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Last number");
            enno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Prime numbers between {0}  and  {1} are: \n", stno , enno);
            for(num=stno; num<=enno; num++) 
            {
                ctr = 0;
                for(i=2; i<=num/2; i++)
                {
                    if(num%i == 0)
                    {
                        ctr++;
                        break;
                    }
                }
                if(ctr == 0 && num != 1) 
                {
                    Console.Write("{0}" ,  num);
                }
            }
            Console.Write(" \n ");
        }

    }
}
