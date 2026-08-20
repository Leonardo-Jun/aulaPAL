using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2 , a;
            Console.WriteLine("Digite o primeiro número:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            n2 = int.Parse(Console.ReadLine());
            a = n1 + n2;
            if(a>30)
            {
                    Console.WriteLine("A soma dos números é maior que 30");
            }   
            else if(a==30)
            {
                Console.WriteLine("A soma dos números é igual a 30");
            }
            else
            {
                Console.WriteLine("A soma dos números é menor que 30");
            }
            Console.ReadKey();
        }
    }
}
