using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР_1
{
    internal class Kolo: Figure
    {
        private double Radius;
        public Kolo()
        {
            Console.WriteLine("--------------------------------------------------------" + 
                              "\n Ввведіть радіус круга:");
            this.Radius = Convert.ToDouble(Console.ReadLine());
        }
        public Kolo(double a) { this.Radius = a; }
        public override double S()
        {
            this.Area = Math.PI * this.Radius * this.Radius;
            return this.Area;
        }
        public override double P()
        {
            this.Per = 2 * Math.PI * this.Radius;
            return this.Per;
        }
        public override void Info()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("--------------------------------------------------------" + "\n Довжина кола: {0}", P());
            Console.WriteLine(" Площа круга: {0}", S());
            Console.WriteLine("--------------------------------------------------------");
        }
    }
}
