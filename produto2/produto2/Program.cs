using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace produto2
{
    class Program
    {
        static void Main(string[] args)
        {
            double quanc, preco, total, desconto, totalpagar;
                string nome;
              Console.WriteLine("Digite o nome do produto:");
            nome=Console.ReadLine();
                Console.WriteLine("Digite o preço unitário do produto:");
            preco=double.Parse(Console.ReadLine());
                Console.WriteLine("Digite quantidade comprada:");
            quanc=double.Parse(Console.ReadLine());
            total=preco*quanc;
            desconto = total * 0.03;
            totalpagar = total - desconto;
                Console.WriteLine("O valor do desconto é de "+ desconto);
                Console.WriteLine("O valor que se vai pagar junto do desconto é de "+ totalpagar);
                Console.ReadKey();
        }
    }
}
