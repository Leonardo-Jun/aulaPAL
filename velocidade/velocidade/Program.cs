using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace velocidade
{
    class Program
    {
        static void Main(string[] args)
        {
            double vel, distancia, t;
            Console.WriteLine("Digite o valor da distância :");
            distancia = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o  valor do  tempo : ");
            t = double.Parse(Console.ReadLine());
            vel = (distancia * 100) / (t * 60);
            Console.WriteLine("O resultado da conta é " + vel);
            Console.ReadKey();
        }
    }
}
