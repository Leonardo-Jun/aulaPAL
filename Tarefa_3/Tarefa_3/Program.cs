using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double total , quanc, preco;
            string nome;
            Console.WriteLine("Digite o nome do produto :");
            nome=Console.ReadLine();
            Console.WriteLine("Digite a quantidade comprada do produto:");
            quanc=double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço unitário do produto :");
               preco=double.Parse(Console.ReadLine());
               total = quanc * preco;
            Console.WriteLine("O preço a se pagar do/a " +nome+" é de "+total);
            Console.ReadKey();

        }
    }
}
