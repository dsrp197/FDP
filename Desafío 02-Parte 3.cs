using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Desafio //02-03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un ángulo c y el valor correspondiente al cateto 1");
            double cgrados = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            double c = cgrados * (Math.PI / 180.0);
            Console.WriteLine("Para un triángulo rectángulo los resultados serían");
            Console.WriteLine("Sen(c) = z/h, por lo tanto h = z/sen(c)");
            double h = z / Math.Sin(c);
            Console.WriteLine("Hipotenusa =" + h);
            Console.WriteLine("Cos(c) = y/h, por lo tanto y = cos(c)*h");
            double y = Math.Cos(c) * h;
            Console.WriteLine("cateto2 =" + y);
            Console.WriteLine("Sen(a) = y/h, por lo tanto a = arcsen(y/h)");
            double a = Math.Asin(y / h) * (180.0 / Math.PI);
            Console.WriteLine("ángulo a =" + a);
            Console.WriteLine("ángulo b = 90 por ser un triángulo rectángulo");

        }
    }
}