using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace laboratorna4
{
    public class Triangle : Point
    {
        protected double l1;
        protected double l2;
        protected double l3;
        protected double angle;

        public Triangle(double x, double y, double l1, double l2, double l3, double angle) : base(x, y)
        {
            this.posX = x;
            this.posY = y;
            this.l1 = l1;
            this.l2 = l2;
            this.l3 = l3;
            this.angle = angle;
            this.colour = "yellow";
        }

        public override (double, double, double) Resize(double fact)
        {
            this.l1 = l1 * fact;
            this.l2 = l2 * fact;
            this.l3 = l3 * fact;
            return (l1,l2, l3);
        }

        public override double Rotate(double angle)
        {
            return angle;
        }

        public override (double, double) Move(double deltaX, double deltaY)
        {
            posX += deltaX;
            posY += deltaY;
            return (posX, posY);
        }

        public override string ChangeColour(string colour)
        {
            return this.colour = colour;
        }

    }
}
