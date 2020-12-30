using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IkinciDerecedenDenklemler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İkinci Dereceden Denklem Çözümü:");
            // ax2 + bx + c = 0
            double a, b, c;
            Console.WriteLine("a sayısını giriniz:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("b sayısını giriniz:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("c sayısını giriniz:");
            c = int.Parse(Console.ReadLine());

            DenklemCozumu(a, b, c);
        }

        static void DenklemCozumu(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;
            double x, x1, x2, i;

            if (delta > 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Çözüm kümesi: {0,8:f4}, {0,8:f4}", x1, x2);
            }
            else if (delta < 0)
            {
                delta = -delta;
                x = -b / (2 * a);
                i = Math.Sqrt(delta) / (2 * a);
                Console.WriteLine("Çözüm kümesi: {0,8:f4} + {1,8:f4} i or {2,8:f4} + {3,8:f4} i", x, i, x, i);
            }
            else
            {
                x = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Çözüm kümesi: {0,8:f4}", x);
            }
        }
    }
}
