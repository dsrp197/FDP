using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Desafio //02-01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese valores correspondientes a cateto 1 y cateto 2");
            double z = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("El resultado de la hipotenusa para el tríangulo rectángulo");
            double h = Math.Sqrt((y * y) + (z * z));
            Console.WriteLine("Hipotenusa =" + h);
            Console.WriteLine("Sen(a) = z/h, por lo tanto a = arcseno(z/h)");
            double a = Math.Asin(z / h) * (180.0 / Math.PI);
            Console.WriteLine("ángulo a =" + a);
            Console.WriteLine("Sen(a) = y/h, por lo tanto a = arcseno(y/h)");
            double c = Math.Asin(y / h) * (180.0 / Math.PI);
            Console.WriteLine("ángulo c =" + c);
            Console.WriteLine("ángulo b = 90 al ser un triángulo rectángulo");
        }
    }
}