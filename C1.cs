using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1
{
    class Program
    {
        static void Main(string[] args)
        {

            Random aleatorio = new Random();
            int dado = 0;
            int total = 0;
            int con = 0;
            int vicon = 0;
            string continuar = "s";


            dado = aleatorio.Next(1, 13);
            total += dado;
            Console.WriteLine("Dado: " + dado);
            Console.WriteLine("Total: " + total);
            continuar = Console.ReadLine();
            if (dado == 10)
            {
                con = con + 1;
            }

            if (continuar == "s")
            {

                dado = aleatorio.Next(1, 13);
                total += dado;
                if (dado == 12)
                {
                    con = con + 1;
                }
                if (dado != 10 && dado != 12)
                {
                    con = 0;
                }
                if (dado == 10 && con >= 1)
                {
                    Console.WriteLine("Dado " + dado);
                    Console.WriteLine("Total: " + total);

                    Console.WriteLine("Comodín! Ganaste por sacar 12 y 10 consecutivamente");
                    vicon = vicon + 2;


                }
                if (vicon < 2)
                {
                    Console.WriteLine("Dado: " + dado);
                    Console.WriteLine("Total: " + total);
                    Console.WriteLine("Desea continuar? (s/n)");
                    continuar = Console.ReadLine();
                    if (continuar == "s")
                    {

                        dado = aleatorio.Next(1, 13);
                        total += dado;
                        if (dado == 10)
                        {
                            con = con + 1;
                        }
                        if (dado != 12 && dado != 10)
                        {
                            con = 0;
                        }
                        if (dado == 12 && con >= 1)
                        {
                            Console.WriteLine("Comodín! Ganaste");
                            vicon = vicon + 2;
                        }
                        if (vicon < 2)
                        {
                            Console.WriteLine("Dado: " + dado);
                            Console.WriteLine("Total " + total);
                            Console.WriteLine("¿Deseas seguir?");
                            continuar = Console.ReadLine();
                        }
                    }
                }
            }

            dado = 2;

            while (continuar == "s" && total < 100 && dado % 2 == 0 && vicon < 2)
            {

                dado = aleatorio.Next(1, 13);
                Console.WriteLine("Dado: " + dado);
                if (dado == 10)
                {
                    con = con + 1;
                }
                if (dado != 12 && dado != 10)
                {
                    con = 0;
                }
                if (dado == 12 && con >= 1)
                {
                    total += dado;
                    Console.WriteLine("Comodín! Ganaste");
                    vicon = vicon + 2;
                }
                if (dado % 2 != 0)
                {
                    total += dado;
                    Console.WriteLine("Perdiste");
                }
                if (total >= 100)
                {
                    Console.WriteLine("Ganaste");
                    total += dado;
                }
                if (dado % 2 == 0 && vicon < 2)
                {
                    total += dado;
                    Console.WriteLine("Total: " + total);
                    if (total < 100)
                    {
                        Console.WriteLine("¿Deseas seguir? (s/n)");
                        continuar = Console.ReadLine();
                    }
                }
            }
            Console.WriteLine("Fin");
            Console.WriteLine("Total: " + total);
        }

    }
}
