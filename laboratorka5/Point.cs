using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorka5
{
    public class Point
    {
        double x, y, cycle, rec;

        public Point(double x, double y, double cycle, double rec)
        {
            this.x = x;
            this.y = y;
            this.cycle = cycle;
            this.rec = rec;
        }

        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }
        public double Cycle { get { return cycle; } set { cycle = value; } }
        public double Rec { get { return rec; } set { rec = value; } }

    }
}
