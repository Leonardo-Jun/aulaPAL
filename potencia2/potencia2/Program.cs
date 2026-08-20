using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace potencia2
{
    class Program
    {
        static void Main(string[] args)
        {
            double potencia, n1, n2;
            Console.WriteLine("Digite o valor do primeiro número:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do segundo número:");
            n2 = double.Parse(Console.ReadLine());
            potencia = Math.Pow(n1, n2);
            Console.WriteLine("O resultado da potência é "+potencia);
            Console.ReadKey();
        }
    }
}
