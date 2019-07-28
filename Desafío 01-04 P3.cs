using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de Ángulo d - Cateto w - Cateto x
            Console.WriteLine("Ingrese los valores del, Ángulo d - Cateto w - Cateto x ");
            double dgrados = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            //Transformación de grados a radianes
            double d = dgrados * (Math.PI / 180.0);

            //Usamos ley de coseno y despejamos t 
            double cosd = Math.Cos(d);
            double t = Math.Sqrt((w * w) + (x * x) - 2 * (w * x * cosd));
            Console.WriteLine("Cateto t =" + t);

            //Usamos ley de seno y despejamos b
            double b = Math.Asin((x * Math.Sin(d)) / t);
            double bgrados = b * (180.0 / Math.PI);
            Console.WriteLine("b =" + bgrados);

            //Despejamos "a" restandole a 180 los dos ángulos principales que conocemos y el complementario
            double agrados = 180.0 - bgrados - dgrados - 90.0;
            double a = agrados * (Math.PI / 180.0);
            Console.WriteLine("a =" + agrados);

            //Usamos sen(a) = y/t & despejamos y
            double y = Math.Sin(a) * t;
            Console.WriteLine("y =" + y);
        }
    }
}
