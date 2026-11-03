double[] peso = new double[6];
double[] altura = new double[6];
int[] idade = new int[6];
string[] nome = new string[6];
for(int i=0;i<6;i++)
{
    Console.WriteLine("Digite o peso da pessoa:");
    peso[i] = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a altura da pessoa:");
    altura[i] = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a idade da pessoa:");
    idade[i] = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o nome da pessoa:");
    nome[i] = Console.ReadLine();
}
for (int i = 0; i < 6; i++)
{
    Console.WriteLine("O peso da pessoa é de " + peso[i]);
    Console.WriteLine("A altura da pessoa é de " + altura[i]);
    Console.WriteLine("O nome da pessoa é de " + nome[i]);
    if (idade[i]>20)
    {
        Console.WriteLine("A idade da pessoa é de " + idade[i]);
    }
    Console.WriteLine("=========================================");
}