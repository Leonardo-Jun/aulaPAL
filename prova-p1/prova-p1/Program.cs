string[] nome = new string[10];
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Digite o nome de um personagem de desenho da posição " + i + "º do vetor");
    nome[i] = Console.ReadLine();
}
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("O nome do personagem de desenho da posição " + i + "º do vetor é=" + nome[i]);
}