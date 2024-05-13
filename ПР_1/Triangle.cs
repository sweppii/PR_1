using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР_1
{
    internal class Triangle: Figure
    {
        private double Side;
        public Triangle()
        {
            Console.WriteLine("--------------------------------------------------------" +
                              "\n Ввведіть сторону трикутника (рівностороннього):");
            this.Side = Convert.ToDouble(Console.ReadLine());
        }
        public Triangle(double a) { this.Side = a; }
        public override double S()
        {
            this.Area = (Math.Sqrt(3) / 4) * (this.Side * this.Side);
            return this.Area;
        }
        public override double P()
        {
            this.Per = 3 * this.Side;
            return this.Per;
        }
        public override void Info()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("--------------------------------------------------------" + "\n Периметр трикутника: {0}", P());
            Console.WriteLine(" Площа трикутника: {0}", S());
            Console.WriteLine("--------------------------------------------------------");
        }
    }
}
