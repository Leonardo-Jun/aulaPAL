string[] nome = new string[6];
int[] idade = new int[6];
string[] cargo = new string[6];
for (int i = 0; i < 6; i++)
{
    Console.WriteLine("Digite o nome do funcionário da posição " + i + "º vetor");
    nome[i] = Console.ReadLine();
    Console.WriteLine("Digite a idade da posição " + i + "º vetor");
    idade[i] = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o cargo da posição " + i + "º vetor(F|M)");
    cargo[i] = Console.ReadLine();
}
for (int i = 0; i < 6; i++)
{
    Console.WriteLine("O nome da pessoa da posição " + i + "º do vetor é=" + nome[i]);
    Console.WriteLine("A idade da posição " + i + "º do vetor é=" + idade[i]);
    Console.WriteLine("O cargo da posição " + i + "º do vetor é=" + cargo[i]);
}