using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp6 { 
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de Ángulo d - Ángulo b y el Cateto Y
            Console.WriteLine("Ingrese los valores del, Angulo d - Ángulo b - Cateto y ");
            double dgrados = double.Parse(Console.ReadLine());
            double bgrados = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            //Transformación de grados a radianes
            double d = dgrados * (Math.PI / 180.0);
            double b = bgrados * (Math.PI / 180.0);


            //Hallamos "a" ya que tenemos 2 ángulos principales y 1 complementario del trángulo mayor
            double agrados = (180.0 - bgrados - dgrados - 90.0);
            double a = agrados * (Math.PI / 180.0);
            Console.WriteLine("Ángulo a =" + agrados);

            //Usamos tan(a) = y/z y despejamos z
            double z = (y / Math.Tan(a));
            Console.WriteLine("Cateto z =" + z);

        }
    }
}

