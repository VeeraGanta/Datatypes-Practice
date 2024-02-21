
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace CA_Examples
{
    internal class Class8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select Products:");
            Console.WriteLine("1. Oneplus Mobile - 45000");
            Console.WriteLine("2. Iphone 15 pro max  -130000");
            Console.WriteLine("3. XBox 360  -35000");
            Console.WriteLine("4. PS 4  -28000");
            Console.WriteLine("5. Samart Watch  -16000");
            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Console.WriteLine("1. Onepuls Mobile - 45000");
                    break;
                case 2:
                    Console.WriteLine("2.Iphone 15 pro max - 130000");
                    break;
                case 3:
                    Console.WriteLine("3.XBox 360  - 35000");
                    break;
                case 4:
                    Console.WriteLine("4.PS 4  -28000");
                    break;
                case 5:
                    Console.WriteLine("5.Smart Watch  -16000");
                    break;

                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }
            Console.WriteLine("Do you want to continue shopping? (Y/N)");
        }
    }
}
