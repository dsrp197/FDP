using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de salario
            Console.WriteLine("Ingrese su salario en cuestión de smmlvm, sabiendo que 1 smmlv = 828,116 COP");
            int salario = int.Parse(Console.ReadLine());

            //Condiciones de acuerdo a el número de smmlv que el usuario adquiere

            if (salario < 2)
            {
                Console.WriteLine("Tarifa A");
            }

            else if (2 <= salario && salario < 4)
            {
                Console.WriteLine("Tarifa B");
            }

            else
            {
                Console.WriteLine("Tarifa C");
            }
        }
    }
}