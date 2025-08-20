using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public delegate T Formula<T>(T arg1, T arg2);

    class CalculatorClass
    {
       
        private Formula<double> _calculateHandler;

        
        public event Formula<double> CalculateEvent
        {
            add
            {
                _calculateHandler += value;
                Console.WriteLine("Added Delegate");
            }
            remove
            {
                _calculateHandler -= value;
                Console.WriteLine("Removed Delegate");
            }
        }

        // Methods to match delegate
        public static double GetSum(double arg1, double arg2)
        {
            return arg1 + arg2;
        }

        public static double GetDifference(double arg1, double arg2)
        {
            return arg1 - arg2;
        }

        public static double GetProduct(double arg1, double arg2)
        {
            return arg1 * arg2;
        }

        public static double GetQuotient(double arg1, double arg2)
        {
            return arg1 / arg2;
        }

        public double Execute(double num1, double num2)
        {
            if (_calculateHandler != null)
            {
                return _calculateHandler(num1, num2);
            }
            else
            {
                Console.WriteLine("No delegated Assign");
                return 0;
            }
        }


    }
}
