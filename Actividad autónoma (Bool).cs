using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Actividad_autónoma__Boole_
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ingreso de datos
            Console.WriteLine("Ingrese votos para el partido a y b");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número votos anulados y votos en blanco respectivamente");
            int anulado = int.Parse(Console.ReadLine());
            int blanco = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la población total y el porcentaje que es mayor de edad");
            int poblacionTotal = int.Parse(Console.ReadLine());
            double porcentaje = double.Parse(Console.ReadLine());
            int mayoresEdad = (int)((poblacionTotal) * (porcentaje / 100));

            int abstinencia = mayoresEdad - a - b - anulado - blanco;
            int numerovotantes = a + b + anulado + blanco;
            //Creación booleanos
            bool totalVotos = (a + b + anulado + blanco) > poblacionTotal;
            bool diferenciaVotos = Math.Abs(a - b) < (numerovotantes * 0.1);
            bool numeroVot = numerovotantes < (poblacionTotal * 0.3);

            //Datos buscados
            if ((totalVotos || diferenciaVotos) && numeroVot)
            {
                Console.WriteLine("Las votaciones se deben ejecutar nuevamente");

            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine("Gana el partido A");
                }
                else
                {
                    Console.WriteLine("Gana el partido B");
                }
            }

        }
    }
}
