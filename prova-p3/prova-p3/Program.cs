int[] idade = new int[4];
for (int i = 0; i < 4; i++)
{
    Console.WriteLine("Digite a idade da criança da posição " + i + "º do vetor");
    idade[i] =int.Parse( Console.ReadLine());
}
for (int i = 0; i < 4; i++)
{
    if (idade[i] > 12)
    {
        Console.WriteLine("A idade da criança da posição " + i + "º do vetor é=" + idade[i]);
    }
}