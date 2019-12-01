using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public abstract class Geometric_figures : IComparable
    {
        public string Type
        {
            get
            {
                return this._Type;
            }
            protected set
            {
                this._Type = value;
            }
        }
        string _Type;
        public abstract double Ploshjad();
        public override string ToString()
        {
            return "Площадь" + " " + this.Type + " " + "равна" + " " + this.Ploshjad().ToString();
        }
        public int CompareTo(object obj)
        {
            Geometric_figures p = (Geometric_figures)obj;
            if (this.Ploshjad() < p.Ploshjad())
            {
                return -1;
            }
            else if (this.Ploshjad() == p.Ploshjad())
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
