using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба2
{
    internal class flatCenter : flat
    {
       string nameDistr;

        public flatCenter(string name, double cost1m, double square, string nameDistr_) : base(name, cost1m, square)
        {
            this.nameDistr = nameDistr_;
        }

        public string NameDistr { get { return this.nameDistr; } set { this.nameDistr = value; } }

        public override double costFlat()
        {
            double cost;
            double costed;

            cost = Cost1m * Square;
            costed = cost / 100;
            cost = cost + costed;

            return cost;
        }
    }
}
