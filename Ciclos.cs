using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int a = 0, b = 0, sumaC = 0, suma = 0, intento = 3;
            while (intento > 0)
            {
                Console.WriteLine("Captcha");
                a = aleatorio.Next(0, 10);
                b = aleatorio.Next(0, 10);
                Console.WriteLine(+a + " + " + b);
                sumaC = a + b;

                Console.WriteLine("Ingrese validación Captcha");
                suma = int.Parse(Console.ReadLine());

                if (sumaC == suma)
                {
                    Console.WriteLine("Validado");
                    Console.WriteLine("Ingresando...");
                    break;
                }
                else if (intento > 1)
                {
                    intento -= 1;
                    Console.WriteLine("No validado");
                    Console.WriteLine("Intentos restantes: " + intento);
                    Console.WriteLine("Intente nuevamente para validar");
                }

                else
                {
                    Console.WriteLine("No validado");
                    Console.WriteLine("Error, no se pudo verificar que usted sea humano, no puede acceder al sitio");
                    intento -= 1;
                }
          
            }
        }
    }
}
