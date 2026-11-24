string[] nome = new string[5];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite o nome de um país da posição " + i + "º do vetor");
    nome[i] = Console.ReadLine();
}
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("O nome do país da posição " + i + "º do vetor é=" + nome[i]);
}