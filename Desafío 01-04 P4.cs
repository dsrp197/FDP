using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de Ángulo c, Cateto w y el Cateto t
            Console.WriteLine("Ingrese Ángulo c & Cateto w & Cateto t ");
            double cgrados = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double t = double.Parse(Console.ReadLine());

            //Transformación de grados a radianes
            double c = cgrados * (Math.PI / 180.0);

            //Hallamos e por medio de su ángulo complementario conocido
            double egrados = 180.0 - cgrados;
            double e = egrados * (Math.PI / 180.0);
            Console.WriteLine("Ángulo e= " + egrados);

            //Usamos ley de seno y despejamos d

            double d = Math.Asin((Math.Sin(e) * t) / w);
            double dgrados = d * (180.0 / Math.PI);
            Console.WriteLine("d =" + dgrados);

            //Hallamos b restando a 180 los ángulos conocidos

            double bgrados = 180.0 - dgrados - egrados;
            double b = bgrados * (Math.PI / 180.0);
            Console.WriteLine("b =" + bgrados);

            //Usamos ley de seno y hallamos x
            double x = (Math.Sin(b) * t) / Math.Sin(d);
            Console.WriteLine("x =" + x);
        }
    }
}