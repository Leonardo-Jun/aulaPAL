using System.Diagnostics.CodeAnalysis;

string[] animal = new string[5];
string[] raca = new string[5];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite o nome do animal da posição " + i + "° do vetor:");
    animal[i] = Console.ReadLine();
    Console.WriteLine("Digite a raça do animal da posição " + i + "° do vetor:");
    raca[i] = Console.ReadLine();
}
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("O nome do animal da posição " + i + "° do vetor é=" + animal[i]);
    Console.WriteLine("A raça do animal da posição " + i + "° do vetor é=" + raca[i]);
}