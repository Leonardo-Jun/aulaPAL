string[] nome = new string[15];
for(int i=0;i<15;i++)
{
    Console.WriteLine("Digite uma cidade da posição " + i + "° do vetor:");
    nome[i] = Console.ReadLine();
}
for(int i=0; i<15;i++)
{
    Console.WriteLine("A cidade da posição " + i + "° do vetor é="+nome[i]);
}