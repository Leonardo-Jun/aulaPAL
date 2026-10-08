string[] nome = new string[4];
int[] idade = new int[4];
string[] sexo = new string[4];
for(int i=0;i<4;i++)
{
    Console.WriteLine("Digite o nome da pessoa da posição " + i + "º vetor");
    nome[i] = Console.ReadLine();
    Console.WriteLine("Digite a idade da posição " + i + "º vetor");
    idade[i] = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o sexo da posição " + i + "º vetor(F|M)");
    sexo[i] = Console.ReadLine();
}
for (int i = 0; i < 4; i++)
{
    Console.WriteLine("O nome da pessoa da posição " + i + "º do vetor é=" + nome[i]);
    Console.WriteLine("A idade da posição " + i + "º do vetor é=" + idade[i]);
    Console.WriteLine("O sexo da posição " + i + "º do vetor é=" + sexo[i]);
}