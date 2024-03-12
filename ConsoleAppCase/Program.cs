using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Insira o número de anos que você trabalhou: ");
            int trab = int.Parse(Console.ReadLine());

            if (idade >= 65 || trab >= 30 || (idade >=60 && trab >= 25))
            {
                Console.Write("Você já pode se aposentar.");
            }
            else
            {
                Console.Write("Você ainda não pode se aposentar.");
            }

            Console.ReadKey();
        }
    }
}
