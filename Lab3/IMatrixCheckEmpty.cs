using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab3
{
    public interface IMatrixCheckEmpty<T>
    {
        T getEmptyElement();
        bool checkEmptyElement(T element);
    }
}
