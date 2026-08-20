using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sen_cos_tang
{
    class Program
    {
        static void Main(string[] args)
        {
            double sen, cos, tang, h, c1, c2;
            Console.WriteLine("Digite o valor da hipotenusa:");
            h=double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do cateto oposto:");
             c1 =double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do cateto adjacente:");
              c2=double.Parse(Console.ReadLine());
            sen=c1/h;
            cos=c2+h;
            tang=c1/c2;
            Console.WriteLine("O resultado do seno é de "+sen);
              Console.WriteLine("O resultado do cosseno é de "+cos);
              Console.WriteLine("O resultado do tangente é de "+tang);
            Console.ReadKey();
        }
    }
}
