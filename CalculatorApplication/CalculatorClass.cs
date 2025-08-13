using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{

    public delegate T Formula<T>(T arg1, T arg2);

    internal class CalculatorClass
    {
        public Formula<double> info;

        public static double GetSum(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double GetDifference(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double GetProduct(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double GetQoutient(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return num1 / num2;
        }

        public event Formula<double> CalculateEvent
        {
            add
            {
               
                Console.WriteLine("Added the Delegate");
            }
            remove
            {
                
                Console.WriteLine("Delegate Removed");
            }
        }

    }
}
