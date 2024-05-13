using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string temp;
            Figure f;
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            do
            {
                Console.WriteLine("Площу та периметр якої фігури ви хочете дізнатися: " +
                "\n Квадрат - напишіть: k" +
                "\n Прямокутник - напишіть: p" +
                "\n Коло - напишіть: c" +
                "\n Трикутник - напишіть: t" +
                "\n--------------------------------------------------------");
            
                temp = Console.ReadLine();
                switch (temp)
                {
                    case "k":
                        f = new Square();
                        f.Info();
                        break;
                    case "p":
                        f = new Rectangle();
                        f.Info();
                        break;
                    case "c":
                        f = new Kolo();
                        f.Info();
                        break;
                    case "t":
                        f = new Triangle();
                        f.Info();
                        break;
                }
                Console.WriteLine("Введіть Enter, щоб вибрати іншу фігуру:");
                Console.ReadLine();
                Console.Clear();
            } while (true);
            
        }
    }
}
