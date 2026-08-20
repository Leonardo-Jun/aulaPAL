using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolar, real;
            Console.WriteLine("Digite o valor que quer converter para reais:");
            dolar = double.Parse(Console.ReadLine());
            real = dolar * 5.29;
            Console.WriteLine("O resultado da conversão de dólar para reais é "+ real);
            Console.ReadKey();
        }
    }
}
