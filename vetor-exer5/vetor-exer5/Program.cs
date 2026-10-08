int[] idade = new int[5];
string[] nome = new string[5];
for(int i=0;i<5;i++)
{
    Console.WriteLine("Digite o nome da posição " + i + "º vetor");
    nome[i] = Console.ReadLine();
    Console.WriteLine("Digite a idade da posição " + i + "º vetor");
    idade[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < 5; i++)
{
    if (idade[i] >= 30)
    {
        Console.WriteLine("O nome da posição " + i + "º do vetor é=" + nome[i]);
        Console.WriteLine("A idade da posição " + i + "º do vetor é=" + idade[i]);
    }
}