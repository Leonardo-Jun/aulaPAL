using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double comprar , quanm, quane;
            Console.WriteLine("Digite o nome do produto :");
           nome=Console.ReadLine();
            Console.WriteLine("Digite a quantidade máxima do produto:");
             quanm=double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade que a em estoque :");
             quane=double.Parse(Console.ReadLine());
             comprar = quanm - quane;
            Console.WriteLine("A quantidade que se precisa se comprar é de "+comprar+" do/a "+nome);
            Console.ReadKey();
        }
    }
}
