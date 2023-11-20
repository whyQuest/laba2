using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorka5
{
    public class sinx
    {

        double x;
        double sqrt;
        double min = 0.001;

        public sinx(double xx)
        {
            this.x = xx;
            sqrt = x * x;
        }

        public sinx() 
        {
            x = 0;
        }

        public double X
        {
            get { return x; } 
        }
        public double CalcCycle(double x, double N)
        {
            double result = 0;
            double term = x;
            double factorial = 1;

            for (int i = 1; i <= N; i++)
            {
                factorial *= 2 * i * (2 * i - 1);
                term = Math.Pow(-1, i) * Math.Pow(x, 2 * i + 1) / factorial;
                result += term;
            }

            return result;
        }

        private double CalculateRec(double x, double N, int i, double factorial, double result)
        {
            if (i > N)
            {
                return result;
            }

            factorial *= 2 * i * (2 * i - 1);
            result += Math.Pow(-1, i) * Math.Pow(x, 2 * i + 1) / factorial;

            return CalculateRec(x, N, i + 1, factorial, result);
        }

        public double CalcWithRec(double x, double N)
        {
            return CalculateRec(x, N, 1, 1, 0);
        }


    }
}
