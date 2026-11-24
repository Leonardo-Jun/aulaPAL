string[] nome = new string[10];
string[] animal = new string[10];
for(int i=0;i<10;i++)
{
    Console.WriteLine("Digite o nome do veterinário da posição " + i + "° do vetor:");
    nome[i] = Console.ReadLine();
    Console.WriteLine("Digite o nome do animal da posição " + i + "° do vetor:");
    animal[i] = Console.ReadLine();
}
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("O nome do veterinário da posição " + i + "° do vetor é=" + nome[i]);
    Console.WriteLine("O nome do animal da posição " + i + "° do vetor é=" + animal[i]);
}