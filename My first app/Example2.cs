

namespace My_first_app
{
     class Example2
    {
        static void Main(string[] args)
        {
            //Implicit Type casting
            short x = 10;  //2 bytes
            int y = x;  //4 bytes
            double z = y;  //8 bytes
            Console.WriteLine("Value of x is: " + x);
            Console.WriteLine("Value of y is: " + y);
            Console.WriteLine("Value of z is: " + z);

           //Explicit type casting
           //c++ Type casting
            double a = 10.23;  //8 bytes
            int b = (int)a;     //4 bytes
            short c = (short)b;   //2 bytes
            Console.WriteLine("Value of a is: " + a);
            Console.WriteLine("Value of b is: " + b);
            Console.WriteLine("Value of c is: " + c);

        }
    }
}
