using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР_1
{
    public class Figure: IFigure
    {
        protected double Per;
        protected double Area;
        public virtual double S() { return Area; }
        public virtual double P() { return Per; }
        public virtual void Info() { }
    }

}
