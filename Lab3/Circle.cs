using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Circle : Geometric_figures, IPrint
    {
        private double radius;
        public double property_radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }
        public Circle(double r)
        {
            this.radius = r;
            this.Type = "Круга";
        }
        public Circle()
        {
            this.Type = "Круга";
        }
        public override double Ploshjad()
        {
            double S = Math.PI * this.radius * this.radius;
            return S;
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
