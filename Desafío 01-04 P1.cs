using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de Datos
            Console.WriteLine("Ingrese valores de: Angulo b - Cateto z - Cateto y ");
            double bGrados = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            //Transformación de grados a radianes
            double b = bGrados * (Math.PI / 180.0);


            //Encontramos la hipotenusa por Pitágoras
            double t = Math.Sqrt((y) * (y) + (z) * (z));
            Console.WriteLine("Hipotenusa t=" + t);

            //Usamos cos(c) = y/t  despejamos t
            double c = (Math.Acos(y / t) * (180.0 / Math.PI));
            Console.WriteLine("Angulo c=" + c);

            //Hallamos el ángulo complementario a c
            double e = (180 - c);
            Console.WriteLine("Angulo e=" + e);

            //Con los dos ángulos conocidos despejamos d
            double dgrados = (180 - bGrados - e);
            double d = (dgrados * (Math.PI / 180.0));
            Console.WriteLine("Angulo d=" + dgrados);

            //Hallamos x por medio de la ley del seno
            double x = ((t * Math.Sin(b)) / Math.Sin(d));
            Console.WriteLine("x = " + x);
        }
    }
}
