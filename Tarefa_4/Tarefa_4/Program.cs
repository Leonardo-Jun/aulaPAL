using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, a, b, perimetro;
            Console.WriteLine("Digite o valor do lado a do retângulo:");
            a=double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do lado b do retângulo:");
              b=double.Parse(Console.ReadLine());
              area = a * b;
              perimetro = a * 2 + 2 * b;
              Console.WriteLine("O resultado da área é de " + area + " já do perímetro do retângulo é de "+perimetro);
            Console.ReadKey();
        }
    }
}
