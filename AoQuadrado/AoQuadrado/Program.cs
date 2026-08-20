using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoQuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            double potencia , soma , n1 , n2 , n3 ;
            Console.WriteLine("Digite o valor do primeiro número:");
            n1=double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do segundo número:");
            n2=double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do terceiro número:");
            n3=double.Parse(Console.ReadLine());
            soma=n1+n2+n3;
            potencia=(soma*soma);
            Console.WriteLine("O resultado da potência é :"+potencia);
            Console.ReadKey();
        }
    }
}
