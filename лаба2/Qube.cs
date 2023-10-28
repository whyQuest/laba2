using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба2
{
    public class Qube : Polynominal
    {
        public double Koef { get; set; }
        public double X { get; set; }

        public Qube(double Koef, double X)
        {
            this.Koef = Koef;
            this.X = X;
            Name = "Кубічний";
        }

        public override double Value()
        {
            double val = (Koef * X) * 3;
            return val;
        }

        public override string Show() 
        {
            return "Багаточлен: " + Name + "; Коефіцієнт: " + Koef.ToString() + "; Невідоме Х: " + X.ToString();
        }
    }
}
