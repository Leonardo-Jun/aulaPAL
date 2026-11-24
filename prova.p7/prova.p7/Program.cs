string[] nome = new string[7];
for (int i = 0; i < 7; i++)
{
        Console.WriteLine("Digite o nome de um país da posição " + i + "° do vetor:");
        nome[i] = Console.ReadLine();
}
for (int i = 0; i < 7; i++)
{
    Console.WriteLine("O nome do país da posição " + i + "° do vetor é="+nome[i]);
}
