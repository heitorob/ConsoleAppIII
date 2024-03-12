using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDecisaoComposta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a média do aluno: ");
            double media = double.Parse(Console.ReadLine());

            Console.Write("Insira a % de presença do aluno: ");
            double pres = double.Parse(Console.ReadLine());

            if (media >= 7 && pres >= 75)
            {
                Console.Write("O aluno está APROVADO.");
            }
            else if (media >= 7 && pres <= 74 || media < 7 && media >= 4 && pres >= 75 )
            {
                Console.Write("O aluno está de RECUPERAÇÃO.");
            }
            else
            {
                Console.Write("O aluno está RETIDO.");
            }

            Console.ReadKey();
        }
    }
}
