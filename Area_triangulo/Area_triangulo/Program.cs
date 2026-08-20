using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, altura, bola;
            Console . WriteLine("Digite o valor da base:");
            bola = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura:");
            altura = double.Parse(Console.ReadLine());
            area = (bola * altura) / 2;
            Console.WriteLine("O valor da área do triângulo é " + area);
            Console.ReadKey();
        }
    }
}
