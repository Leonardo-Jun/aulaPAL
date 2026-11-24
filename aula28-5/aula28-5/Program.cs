string[] nome = new string[5];
int[] idade = new int[5];
double[] peso = new double[5];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("digite o nome da pessoa da posição " + i + "° do vetor:");
    nome[i] = Console.ReadLine();
    Console.WriteLine("Digite a idade da pessoa da posição " + i + "° do vetro:");
    idade[i] = int.Parse(Console.ReadLine());
    Console.WriteLine("digite o peso da pessoa da posição " + i + "° do vetor:");
    peso[i] = double.Parse(Console.ReadLine());
}
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("O nome da pessoa da posição " + i + "° do vetor: é=" + nome[i]);
    Console.WriteLine("A idade da pessoa da posição " + i + "° do vetro é=" + idade[i]);
    Console.WriteLine("O peso da pessoa da posição " + i + "° do vetor é=" + peso[i]);
}