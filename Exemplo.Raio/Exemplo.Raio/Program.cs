using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo.Raio
{
    class Program
    {
        static void Main(string[] args)
        {
            //comando de variáveis
            double num, raio , area;
            ;//comando escreva
            Console.WriteLine("Digite o valor do raio : ");
            raio = double.Parse(Console.ReadLine());
            area = (3.14 * (raio * raio));
            Console.WriteLine("O resultado da área é " + area);
            Console.ReadLine();
        }
    }
}
