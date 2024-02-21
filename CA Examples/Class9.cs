

namespace CA_Examples
{
    internal class Class9
    {
        static void Main(string[] args)
        {
            int n , first =0, second =1, next;

            Console.WriteLine("Enter number of elements");
            n= Convert.ToInt32(Console.ReadLine());

            Console.Write("Fibonacci Series:");
            
            for(int i = 0; i < n; i++) 
            {
             if(i<=1)
                    next = i;  
             else
                {
                    next = first + second;
                    first = second; 
                    second=next;
                }
                Console.Write(next + "");
            }
            Console.WriteLine();

        }


    }
}
