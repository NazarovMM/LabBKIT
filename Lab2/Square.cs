using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Square : Rectangle, IPrint
    {
        public Square(double dlina)
            : base(dlina, dlina)
        {
            this.Type = "Квадрата";
        }
        public Square() : base()
        {
            this.Type = "Квадрата";
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
