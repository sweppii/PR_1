using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ПР_1
{
    internal class Square: Figure
    {
        private double Side;
        public Square()
        {
            Console.WriteLine("--------------------------------------------------------" +
                              "\n Ввведіть сторону квадрата:");
            this.Side = Convert.ToDouble(Console.ReadLine());
        }
        public Square(double a) { this.Side = a; }
        public override double S() 
        {
            this.Area = this.Side * this.Side;
            return this.Area; 
        }
        public override double P()
        {
            this.Per = 4 * this.Side;
            return this.Per;
        }
        public override void Info()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("--------------------------------------------------------" + "\n Периметр квадрата: {0}", P());
            Console.WriteLine(" Площа квадрата: {0}", S());
            Console.WriteLine("--------------------------------------------------------");
        }


    }
}
