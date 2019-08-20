using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicio
            Console.WriteLine("Esto es BlackJack");
            Console.ReadLine();

            //Variables
            int Total = 0;
            string continuar = "si";
            int ValorCarta1 = 0;
            int ValorCarta2 = 0;
            int ValorCartaExtra = 0;
            Random carta = new Random();

            //Inicio del juego
            Console.WriteLine("¿Desea iniciar? (responda si o no)");
            continuar = Console.ReadLine();

            if (continuar == "si")
            {

                ValorCarta1 = carta.Next(1, 11);
                ValorCarta2 = carta.Next(1, 11);
                Console.WriteLine("ValorCarta1: " + ValorCarta1);
                Console.WriteLine("ValorCarta2: " + ValorCarta2);
                Total = ValorCarta1 + ValorCarta2;
                Console.WriteLine("Total: " + Total);
                Console.WriteLine("¿Desea continuar? (responda si o no)");
                continuar = Console.ReadLine();

                while (continuar == "si" && Total <= 21)
                {
                    ValorCartaExtra = carta.Next(1, 11);
                    Console.WriteLine("Valor Carta Extra = " + ValorCartaExtra);
                    Total += ValorCartaExtra;
                    Console.WriteLine("Total: " + Total);

                    if (Total > 21)
                    {
                        Console.WriteLine("Perdiste");
                    }

                    else
                    {
                        Console.WriteLine("¿Desea continuar? (responda si o no)");
                        continuar = Console.ReadLine();
                        if (continuar == "no")
                        {
                            Console.WriteLine("Total :" + Total);
                            Console.WriteLine("Gracias por jugar");
                        }
                    }


                }


            }

            else if (continuar == "no")
            {
                Console.WriteLine("...");
            }



        }
    }
}