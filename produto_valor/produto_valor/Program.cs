using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace produto_valor
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorp1, valor1, quan1, valort, valorp2, valorp3, quan2, quan3 , valor2 , valor3;
            string  nome1, nome2, nome3;
            Console.WriteLine("Digite o nome do primeiro produto:");
            nome1 = Console.ReadLine();
            Console.WriteLine("Digite o nome do segundo produto:");
            nome2 = Console.ReadLine();
            Console.WriteLine("Digite o nome do terceiro produto:");
            nome3 = Console.ReadLine();
            Console.WriteLine("Digite o valor do primeiro produto:");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade que se tem do primeiro produto:");
            quan1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do segundo produto:");
            valor2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade que se tem do segundo produto:");
            quan2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do terceiro produto:");
            valor3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade que se tem do terceiro produto:");
            quan3 = double.Parse(Console.ReadLine());
            valorp1 = valor1 * quan1;
            valorp2 = valor2 * quan2;
            valorp3 = valor3 * quan3;
            valort = valorp1 + valorp2 + valorp3;
            Console.WriteLine(nome1+" tem um valor igual a "+ valor1);
            Console.WriteLine(nome2 + " tem um valor igual a " + valor2);
            Console.WriteLine(nome3 + " tem um valor igual a " + valor3);
            Console.WriteLine("O valor total desses produtos juntos é de "+ valort);
            Console.ReadKey();

        }
    }
}
