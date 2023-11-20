using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorka5
{
    public class Tabulistan
    {
        public List<Point> points = new List<Point>();

        public void add(Point point)
        {
            points.Add(point);
        }

        public void GetList(double xn, double xk, double h)
        {
            try 
            {
                var x = xn;
                double y = 0, cycle = 0, rec = 1;
                while(x < xk)
                {
                    var sin = new sinx(x);
                    y = Math.Sin(x) / x;
                    cycle = sin.CalcCycle(1.2, 10);
                    rec = 1;
                    sin.CalcWithRec(1.2, 10);
                    var point = new Point(x, y, cycle, rec);
                    add(point);
                    x = x + h;
                }
            }
            catch (Exception ex)
            {

            }
        }


    }
}
