using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Rectangle : Geometric_figures, IPrint
    {
        private double shirina;
        private double visota;
        public double property_shirina
        {
            get
            {
                return shirina;
            }
            set
            {
                shirina = value;
            }
        }
        public double property_visota
        {
            get
            {
                return visota;
            }
            set
            {
                visota = value;
            }
        }
        public Rectangle(double s, double v)
        {
            this.shirina = s;
            this.visota = v;
            this.Type = "Прямоугольника";
        }
        public Rectangle()
        {
            this.Type = "Прямоугольника";
        }
        public override double Ploshjad()
        {
            double S = this.shirina * this.visota;
            return S;
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
