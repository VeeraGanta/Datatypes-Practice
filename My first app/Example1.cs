
namespace My_first_app
{
    class Example1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Product Name:");
            String productName = Console.ReadLine();
            Console.WriteLine("Enter Product Price:");
            double productPrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Quantitiy:");
            int quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("User selected product is " + productName + " and cost is:" +(productPrice * quantity));


        }
    }
}
