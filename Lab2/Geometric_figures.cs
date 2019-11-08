using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    abstract class Geometric_figures
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
    }
}
