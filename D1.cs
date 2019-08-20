using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();

            int dadouno = 0;
            int dadodos = 0;
            int total = 0;
            string continuar = "s";
            int contador = 0;
            int mayor = 0;
            int turnos = 0;

            while (continuar == "s" && dadouno + dadodos != 2)
            {
                dadouno = aleatorio.Next(1, 7);
                Console.WriteLine("Dado 1: " + dadouno);
                dadodos = aleatorio.Next(1, 7);
                Console.WriteLine("Dado 2: " + dadodos);
                turnos += 1;



                if (dadouno == 1 && dadodos == 1)
                {
                    total = 0;
                    Console.WriteLine("Eliminado");

                }

                else
                {
                    total += dadouno + dadodos;
                    Console.WriteLine("Total: " + total);
                    if ((dadouno + dadodos) > 6)
                    {
                        mayor += 1;
                    }

                    if (total >= 100)
                    {
                        Console.WriteLine("Has ganado, felicidades");
                        continuar = "";
                    }
                    else if (dadouno == dadodos)
                    {
                        contador += 1;

                        if (contador == 3)
                        {
                            Console.WriteLine("Has ganado, felicidades");
                            continuar = "";
                        }

                        Console.WriteLine("¿Deseas seguir?  (s/n) :");
                        continuar = Console.ReadLine();
                    }



                    else if (dadouno != dadodos)
                    {
                        contador = 0;
                        Console.WriteLine("¿Deseas seguir?  (s/n) :");
                        continuar = Console.ReadLine();
                    }


                    else
                    {
                        Console.WriteLine("¿Deseas seguir?  (s/n) :");
                        continuar = Console.ReadLine();
                    }


                }
            }

            mayor = (mayor * 100) / turnos;
            Console.WriteLine("Su total fue de " + total + " puntos");
            Console.WriteLine("Gracias por jugar");
            Console.WriteLine("La suma de sus dados fue mayor a seis " + mayor + "% de las veces");


        }
    }
}