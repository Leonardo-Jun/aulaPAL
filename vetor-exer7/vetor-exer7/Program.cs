string[] n = new string[7];
for (int i = 0; i < 7; i++)
{
    Console.WriteLine("Digite o nome do time de futebol da posição " + i + "º do vetor");
    n[i] = Console.ReadLine();
}
for (int i = 0; i < 7; i++)
{
    Console.WriteLine("O nome do time de futebol da posição " + i + "º do vetor é=" + n[i]);
}