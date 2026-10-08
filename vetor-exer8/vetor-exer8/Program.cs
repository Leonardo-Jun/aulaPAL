int[] preco = new int[5];
string[] nome = new string[5];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite o nome do produto comprado da posição " + i + "º vetor");
    nome[i] = Console.ReadLine();
    Console.WriteLine("Digite o preço do produto da posição " + i + "º vetor");
    preco[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < 5; i++)
{
        Console.WriteLine("O nome do produto comprado da posição " + i + "º do vetor é=" + nome[i]);
        Console.WriteLine("O preço do produto da posição " + i + "º do vetor é=" + preco[i]);
}