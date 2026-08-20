using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double imc, peso, altura;
            Console.WriteLine("digite o peso da pessoa:");
            peso=double.Parse(Console.ReadLine());
            Console.WriteLine("digite a altura da pessoa :");
             altura =double.Parse(Console.ReadLine());
            imc=peso/(altura*altura);
            Console.WriteLine("O resultado do IMC da pessoa é de "+ imc);
            Console.ReadKey();
        }
    }
}
