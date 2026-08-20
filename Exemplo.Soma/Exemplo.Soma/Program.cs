using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo.Soma
{
    class Program
    {
        static void Main(string[] args)
        {
        //declaração de variável
            double n1, n2, soma;
            //comando escreva
            Console.WriteLine("Digite o primeiro número : ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número : ");
            n2 = double.Parse(Console.ReadLine());
            //comando leia , para converter para real double.Parse
            soma = n1 + n2;
            Console.WriteLine("O resultado da soma é " + soma);
            //para a tela não fechar ao executar
            Console . ReadKey();
        }
    }
}
