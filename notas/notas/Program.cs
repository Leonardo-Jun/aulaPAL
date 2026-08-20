using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notas
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double nota1, nota2, trabalho1, trabalho2, lista , media ;
            Console.WriteLine("Digite o nome do aluno:");
            nome=Console.ReadLine();
            Console.WriteLine("Digite a nota do primeiro trabalho:");
              trabalho1 =double.Parse(Console.ReadLine());
              Console.WriteLine("Digite a nota do segundo trabalho:");
               trabalho2=double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota da primeira prova:");
              nota1 =double.Parse(Console.ReadLine());
              Console.WriteLine("Digite a nota da segunda prova:");
              nota2 =double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota da lista de exercício:");
            lista = double.Parse(Console.ReadLine());
            media = (nota1 + nota2 + trabalho1 + trabalho2 + lista) / 5;
            Console.WriteLine("A média da/o "+nome+" é de :"+ media);
            Console.ReadKey();
        }
    }
}
