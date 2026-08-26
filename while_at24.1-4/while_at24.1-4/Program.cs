string nome;
double cont = 1, a, b, m;
while(cont<=5)
{
    Console.WriteLine("Digite o nome do aluno:");
    nome = Console.ReadLine();
    Console.WriteLine("Digite a nota A do aluno(a):");
    a = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a nota B do aluno(a):");
    b = double.Parse(Console.ReadLine());
    m = (a + b) / 2;
    Console.WriteLine("O/A " + nome + " tem a média de " + m);
    cont++;
}