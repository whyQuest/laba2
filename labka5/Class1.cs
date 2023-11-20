using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labka5
{
    public class Class1 : Component
    {

        public static double Factorial(double n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
        public double CalcCycle(double x, double N)
        {
            double sum = 0.0;

            for (double i = 1; i <= 20; i++)
            {
                double term = Math.Pow(-1, i) * (Math.Pow(x, 2 * i - 1) / Factorial(2 * i - 1));
                sum += term;
            }

            return sum;
        }

        private double CalculateRec(double x, double N, int i, double result)
        {
            if (i > 50)
            {
                return result;
            }

                double term = Math.Pow(-1, i) * (Math.Pow(x, 2 * i - 1) / Factorial(2 * i - 1));
                result += term;

            return CalculateRec(x, N, i + 1, result);
        }

        public double CalcWithRec(double x, double N)
        {
            return CalculateRec(x, N, 1, 0);
        }

    }
}
