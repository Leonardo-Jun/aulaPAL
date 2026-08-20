using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salario_professor
{
    class Program
    {
        static void Main(string[] args)
        {
            double sl, sb, horas, valora, percinss;
            Console.WriteLine("Digite a quantidade de horas trabalhadas pelo professor:");
            horas=double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade que se ganha por aula dada:");
             valora=double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o percentual de desconto do INSS:");
             percinss=double.Parse(Console.ReadLine());
             sb = horas * valora;
             sl = sb - (sb * percinss / 100);
            Console.WriteLine("O valor do salário líquido ganho é de "+sl);
            Console.ReadKey();
        }
    }
}
