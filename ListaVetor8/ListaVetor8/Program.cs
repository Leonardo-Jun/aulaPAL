int[] idade = new int[8];
string[] nome = new string[8];
string[] curso = new string[8];
for (int i = 0; i < 8; i++)
{
        Console.WriteLine("Digite o nome do/a aluno/a:");
        nome[i] = Console.ReadLine();
        Console.WriteLine("Digite o curso do/a aluno/a:");
        curso[i] =Console.ReadLine();
        Console.WriteLine("Digite a idade do/a aluno/a:");
        idade[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < 8; i++)
{
    {
        Console.WriteLine("O nome da posição " + i + "º do vetor é=" + nome[i]);
        Console.WriteLine("O curso da posição " + i + "º do vetor é=" + curso[i]);
        Console.WriteLine("A idade da posição " + i + "º do vetor é=" + idade[i]);
    }
}