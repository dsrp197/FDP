using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de datos 
            Console.WriteLine("Ingrese votos para el partido a(1) y b(2) respectivamente");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de votos anulados y en blanco");
            int anulado = int.Parse(Console.ReadLine());
            int blanco = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la población total y el porcentaje que es mayor de edad");
            int poblacióntotal = int.Parse(Console.ReadLine());
            int porcentaje = int.Parse(Console.ReadLine());

            int númerovotantes = a + b + anulado + blanco;
            Console.WriteLine("númerovotantes =" + númerovotantes);
            int Poblaciónmayordeedad = (porcentaje * poblacióntotal)/100 ;
            Console.WriteLine("Poblaciónmayordeedad =" + Poblaciónmayordeedad);
            int abstinencia = Poblaciónmayordeedad - númerovotantes;
            Console.WriteLine("abstinencia =" + abstinencia);
            //Booleanos
            bool anulados = anulado < ((a + b) * 0.3);
            bool votosblanco = (a + b) > blanco;
            bool abstinenciatotal = abstinencia < númerovotantes;

            //Datos
            if ((anulados || votosblanco) && abstinencia<númerovotantes)
            {
                Console.WriteLine("La votación fue exitosa");
                if (a > b)
                {
                    Console.WriteLine("Gana el partido");
                }
                else if (b < a)
                {
                    Console.WriteLine("Gana el partido 2");
                }
                else (a == b);
                { 
                    Console.WriteLine("Debe realizarse segunda vuelta");
                }
            
            }
            else {
                Console.WriteLine("La votación debe ser realizada nuevamente");
            }
        }


        }
    }

