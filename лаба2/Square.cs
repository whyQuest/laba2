using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба2
{
    public class Square : Polynominal
    {
        public double Koef { get; set; }
        public double X {  get; set; } 
        public Square(double Koef, double X)
        {
            this.Koef = Koef;
            this.X = X;
            Name = "Квадратний";
        }

        public override double Value()
        {
            return (Koef * X) * 2;
        }

        public override string Show()
        {
            return "Багаточлен: " + Name + "; Коефіцієнт: " + Koef + "; Невідоме Х: " + X.ToString();
        }
    }
}
