using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorna4
{
    public class Point
    {
        protected double posX;
        protected double posY;
        protected double Delta = 50;
        protected string colour;

        public Point(double x, double y)
        {
            this.posX = x;
            this.posY = y;
            this.colour = "green";

        }
        public virtual (double, double) Move(double deltaX, double deltaY)
        {
            posX += deltaX;
            posY += deltaY;
            return (posX, posY);
        }
        public virtual (double, double, double) Resize(double factor) { return (0, 0, 0); }
        public virtual double Rotate(double angle) { return angle; }
        public virtual string ChangeColour(string colour) { return this.colour = colour; }
    }
}
