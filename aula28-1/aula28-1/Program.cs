string[] nome = new string[12];
for(int i=0;i<12;i++)
{
    Console.WriteLine("Digite o nome de um cantor/a da posição " + i + "° do vetor:");
    nome[i] = Console.ReadLine();
}
for(int i=0;i<12;i++)
{
    Console.WriteLine("O nome do/a cantor/a da posição " + i + "° do vetor é=" + nome[i]);
}