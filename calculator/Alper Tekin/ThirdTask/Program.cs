using System;

namespace ThirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            int sub = num1 - num2;
            int mlt = num1 * num2;
            int div = num1 / num2;
            Console.WriteLine("The sum is:"+sum);
            Console.WriteLine("The subtraction is:" + sub);
            Console.WriteLine("The multiplication is:" + mlt);
            Console.WriteLine("The division is:" + div);

        }
    }
}
