using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double area , bola , altura ;
            Console.WriteLine("Digite o valor da base do triângulo:");
            bola=double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura do triângulo:");
                  altura =double.Parse(Console.ReadLine());
            area=(bola*altura)/2;
            Console.WriteLine("O resultado da área do triângulo é de "+area);
            Console.ReadKey();
        }
    }
}
