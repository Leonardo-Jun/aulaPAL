string[] nome = new string[8];
int[] ano = new int[8];
for(int i=0;i<8;i++)
{
    Console.WriteLine("Digite o nome de um filme da Marvel da posição " + i + "º do vetor");
    nome[i] = Console.ReadLine();
    Console.WriteLine("Digite o ano de lançamentodo filme da posição " + i + "º do vetor");
    ano[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < 8; i++)
{
    Console.WriteLine("O nome de um filme da Marvel da posição " + i + "º do vetor é=" + nome[i]);
    Console.WriteLine("O ano de lançamentodo filme da posição " + i + "º do vetor é=" + ano[i]);
}