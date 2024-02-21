namespace CA_Examples
{
    internal class Class7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("int x =");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("int y =");
            int y = Convert.ToInt32(Console.ReadLine());

            x = x + y;
            y = x - y;
            x = x - y;

            Console.WriteLine("int x =" +x);
            Console.WriteLine("int y =" + y);

                
        }
    }
}
