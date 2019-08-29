using System;

namespace _4FunctionCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter a Number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            /* Checking for to see if user put in an add symbol */
            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            /* Checking for to see if user put in an subtract symbol */
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            /* Checking for to see if user put in an times symbol */
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            /* Checking for to see if user put in an divide symbol */
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            /* If user inputs anything other then the above four functions an error message apperars */
            else
            {
                Console.WriteLine("Invalide Operator");
            }

            Console.ReadLine();
        }
    }
}
