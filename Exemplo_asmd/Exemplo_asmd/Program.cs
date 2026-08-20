using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_asmd
{
    class Program
    {
        static void Main(string[] args)
        {
            double mult, div, adic, sub, n1, n2;
            Console.WriteLine("Digite o valor do primeiro número :");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do segundo número:");
            n2 = double.Parse(Console.ReadLine());
            mult = n1 * n2;
            div = n1 / n2;
            adic = n1 + n2;
            sub = n1 - n2;
            Console.WriteLine("Multiplicação:"+ mult + " Divisão:"+div + " Adição:"+ adic + " Subtração:"+ sub);
           
            Console.ReadKey();

        }
    }
}
