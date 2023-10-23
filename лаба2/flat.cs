using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба2
{
    internal class flat
    {
        string name;
        double cost1m;
        double square;

        public flat(string name_, double cost1m_, double square_)
        {
            this.name = name_;
            this.cost1m = cost1m_;
            this.square = square_;
        }

        public string NAME { get { return name; }  set { name = value; } }

        public double Cost1m { get {  return cost1m; } set {  cost1m = value; } }

        public double Square { get { return square; } set {  square = value; } }

        public virtual double costFlat()
        {
            double cost = 0.0;
            cost = cost1m * square;
            return cost;
        }

    }
}
