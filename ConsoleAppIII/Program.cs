using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            Console.Write("Insira seu peso: ");
            double peso = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine("Seu IMC é " + imc.ToString("F3"));

            if (imc < 16.9)
            {
                Console.Write("Classificação: Muito abaixo do peso.");
            } 
            else if (imc < 18.4)
            {
                Console.Write("Classificação: Abaixo do peso.");
            } 
            else if (imc < 24.9)
            {
                Console.Write("Classificação: Peso normal.");
            }
            else if (imc < 29.9)
            {
                Console.Write("Classificação: Acima do peso.");
            }
            else if (imc < 34.9)
            {
                Console.Write("Classificação: Obesidade grau I.");
            }
            else if (imc < 40.1)
            {
                Console.Write("Classificação: Obesidade grau II.");
            }
            else
            {
                Console.Write("Classificação: Obesidade grau III.");
            }

            Console.ReadKey();
        }
    }
}
