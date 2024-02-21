
namespace My_first_app
{
     class Example3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Eno: ");
            int empNo = Convert .ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Ename: ");
            string empname = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary");
            double empSalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Percentage: ");
            short empInc= Convert.ToInt16(Console.ReadLine());

            int totalsal = Convert.ToInt32((empSalary * empInc / 100) + empSalary);
            string total = Convert.ToString (totalsal);
            Console.WriteLine("Employee Name is: " + empname + "and Salary is: " + total);
        }
    }
}
