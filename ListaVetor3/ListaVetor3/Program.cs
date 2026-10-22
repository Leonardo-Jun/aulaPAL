int[] n = new int[10];
double resto;
for (int i = 0;i<10;i++)
{
    Console.WriteLine("Digite um número:");
    n[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < 10; i++)
{
    resto = n[i] % 4;
    if (resto == 0)
    {
        Console.WriteLine("O número da posição " + i + "º do vetor é múltiplo de 4 que é=" + n[i]);
    }
}