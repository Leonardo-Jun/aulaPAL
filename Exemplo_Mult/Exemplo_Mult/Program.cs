using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Mult
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração de variável
            int mult, num;
            //comando escreva
            Console.WriteLine("Digite um número:");
            //comando leia, para converter para inteiro int.Parse
            num=int.Parse(Console.ReadLine());
            mult=num*10;
            Console.WriteLine("O resultado da multiplicação é "+ mult);
            //Para a tela não fechar ao executar
            Console.ReadKey();
        }
    }
}
