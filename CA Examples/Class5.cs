
namespace CA_Examples
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());
            int num5 = Convert.ToInt32(Console.ReadLine());

            int highest = num1;
            int lowest = num1;

            if(num2> highest) 
                highest = num2;
            else if(num2< lowest)
                lowest = num2;
            if (num3> highest)
                highest = num3;
            else if(num3<lowest)
                lowest = num3;
            if (num4 > highest)
                highest = num4;
            else if(num4 < lowest)
                lowest = num4;
            if (num5 > highest)
                highest = num5;
            else if (num5<lowest)
            lowest = num5;

            Console.WriteLine("Highest number: " + highest);
            Console.WriteLine("Lowest number: " + lowest);


        }
    }
}
