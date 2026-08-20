using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Cubo
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, bola, volume;
            Console.WriteLine("Digite o valor da base :");
            bola = double.Parse(Console.ReadLine());
            area = Math.Pow(bola, 2);
            volume = Math.Pow(bola, 3);
            Console.WriteLine("O resultado da área do quadrado é "+area);
            Console.WriteLine("O resultado do volume do quadrado é "+volume);
            Console.ReadKey();

        }
    }
}
