using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TRANSPORTE_FRUTAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String tipoFruta;
            int distanciaKilometros;
            int costoTotal;
            int costoCaja;
            Console.WriteLine("Ingrese el tipo de fruta (Naranja, Fresa o Mango): ");
             tipoFruta = Console.ReadLine();

            Console.WriteLine("Ingrese la distancia en kilómetros: ");
             distanciaKilometros = int.Parse(Console.ReadLine());
            switch (tipoFruta)
            {
                case "Naranja":
                    if (distanciaKilometros < 30)
                    {
                        costoCaja = 2;
                    }
                    else
                    {
                        costoCaja = 4;
                    }
                    break;
                case "Fresa":
                    if (distanciaKilometros < 30)
                    {
                        costoCaja = 6;
                    }
                    else
                    {
                        costoCaja = 9;
                    }
                    break;
                case "Mango":
                    if (distanciaKilometros < 30)
                    {
                        costoCaja = 3;
                    }
                    else
                    {
                        costoCaja = 5;
                    }
                    break;
                default:
                    Console.WriteLine("Tipo de fruta no válido.");
                    return ;
            }

            Console.WriteLine($"El costo por caja de frutas es: S/{costoCaja}");
            Console.ReadKey();
    

        }    
    } 
}
