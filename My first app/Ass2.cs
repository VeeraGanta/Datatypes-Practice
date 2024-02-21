
namespace My_first_app
{
    class Ass2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter EmpID: ");
            double EmpId = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name: ");
            string EmployeeName = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            double Salary = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Increment");
            double Increment=Double.Parse(Console.ReadLine());
            double IncrementAmount = (Increment / 100) * Salary;
            Console.WriteLine("Welcome " +  EmployeeName  + " and your total salary is :" + (Salary+IncrementAmount));
        }
    }
}
