using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР_1
{
    internal class Rectangle: Figure
    {
        private double Width;
        private double Height;
        public Rectangle()
        {
            Console.WriteLine("--------------------------------------------------------" +
                              "\n Ввведіть висоту прямокутника:");
            this.Height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ввведіть ширину прямокутника:");
            this.Width = Convert.ToDouble(Console.ReadLine());
        }
        public Rectangle(double a, double b) { this.Width = a; this.Height = b; }

        public override double S()
        {
            this.Area = this.Width * this.Height;
            return this.Area;
        }
        public override double P()
        {
            this.Per = (this.Width + this.Height) * 2;
            return this.Per;
        }
        public override void Info()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("--------------------------------------------------------" +
                "\n Периметр прямокутника: {0}", P());
            Console.WriteLine(" Площа прямокутника: {0}", S());
            Console.WriteLine("--------------------------------------------------------");
        }
    }
}
