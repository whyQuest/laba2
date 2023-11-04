using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace laboratorna4
{
    public class EqTriangle : Triangle
    {
        public EqTriangle(double x, double y, double l1, double l2, double l3, double angle) : base(x, y, l1, l2, l3, angle)
        {
            this.posX = x;
            this.posY = y;
            this.l1 = l1;
            this.l2 = l2;
            this.l3 = l3;
            this.angle = angle;
            this.colour = "red";
        }

        public override (double, double, double) Resize(double fact)
        {
            return (l1 * fact, l2 * fact, l3 * fact);
        }

        public override double Rotate(double angle)
        {
            return angle;
        }

        public override(double, double) Move(double deltaX, double deltaY)
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
