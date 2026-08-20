using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movel
{
    class Program
    {
        static void Main(string[] args)
        {
            double valortotal, valor, taxa, parcelas;
            Console.WriteLine("Digite o valor do móvel:");
            valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a taxa dos juros:");
            taxa = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor das parcelas:");
            parcelas = double.Parse(Console.ReadLine());
            valortotal = valor + (valor * (taxa / 100) * parcelas);
            Console.WriteLine("O valor total imposto pela loja é de " + valortotal);
            Console.ReadKey();

        }
    }
}
