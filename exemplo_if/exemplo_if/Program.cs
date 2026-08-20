using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Digite o número:");
            n = int.Parse(Console.ReadLine());
            if(n>80)
            {
            Console.WriteLine("O número é  maior que 80 ");
            }
            else if (n==80)
            {
            Console.WriteLine("O número é igual a 80 ");
            }        
            else
            {
            Console.WriteLine("O número é menor que 80");
            }
            Console.ReadKey();