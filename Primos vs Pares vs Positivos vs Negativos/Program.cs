using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primos_vs_Pares_vs_Positivos_vs_Negativos
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num;
            int i = 1;
            int ContadorPositivo = 0;
            int ContadorNegativo = 0;
            int ContadorPares = 0;
            int ContadorPrimo = 0;
            int CantidadPrimo = 0;
            Console.Write("Ingrese un Número por favor: ");
            Num = int.Parse(Console.ReadLine());
            while(Num != 0)
            {
                if (Num > 0)
                {
                    ContadorPositivo = ContadorPositivo + 1;
                    if(Num % 2 == 0)
                    {
                        ContadorPares = ContadorPares + 1;
                    }
                    while(i <= Num)
                    {
                        if(Num % i == 0)
                        {
                            ContadorPrimo = ContadorPrimo + 1;
                        }
                        i = i + 1;
                    }
                    if(ContadorPrimo == 2)
                    {
                        CantidadPrimo = CantidadPrimo + 1;
                    }
                        
                }
                else
                {
                    ContadorNegativo = ContadorNegativo + 1;
                }

                Console.Write("Ingrese un Número por favor: ");
                Num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("La cantidad de numeros Positivos es: {0} ", ContadorPositivo);
            Console.WriteLine("La cantidad de numeros Negativos es: {0} ", ContadorNegativo);
            Console.WriteLine("La cantidad de numeros Pares es: {0} ", ContadorPares);
            Console.WriteLine("La cantidad de numeros Primos es: {0} ", CantidadPrimo);
            Console.Read();
        }
    }
}
