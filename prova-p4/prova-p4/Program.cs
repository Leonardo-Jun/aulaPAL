int[] idade = new int[20];
double r;
for (int i = 0; i < 20; i++)
{
    Console.WriteLine("Digite a idade da pessoa da posição " + i + "º do vetor");
    idade[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < 20; i++)
{
    r = idade[i] % 2;
    if(r==0)
    {
        Console.WriteLine("O nome da pessoa da posição " + i + "º do vetor é=" + idade[i]);
    }
}