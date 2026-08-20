using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume , r , altura ;
            Console.WriteLine("Digite o valor do raio do cilindro:");
            r=double.Parse(Console.ReadLine());
              Console.WriteLine("Digite o valor da altura:");
             altura=double.Parse(Console.ReadLine());
            volume=3.14*Math.Pow(r,2)*altura;
            Console.WriteLine("O valor do volume do cilindro é " + volume);
            Console.ReadKey();
        }
    }
}
