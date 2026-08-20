using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double alturap, largurap, alturaa, larguraa, areap, areaa, quana;
            Console.WriteLine("Digite o valor da altura da parede:");
            alturap=double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da largura da parede:");
               largurap=double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura do azulejo:");
               alturaa=double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da largura do azulejo:");
               larguraa=double.Parse(Console.ReadLine());
               areap = largurap * alturap;
               areaa = larguraa * alturaa;
               quana = areap / areaa;
             Console.WriteLine("A quantidade neessária de azulejos para se usar na parede é de "+quana);
            Console.ReadKey();
        }
    }
}
