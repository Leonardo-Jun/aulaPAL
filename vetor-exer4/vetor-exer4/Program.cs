int[] n = new int[10];
double resto;
for (int i = 0;i<10;i++)
{
    Console.WriteLine("Digite o número da posição " + i + "º vetor");
    n[i]= int.Parse(Console.ReadLine());
}
for (int i = 0; i < 10; i++)
{
    resto = n[i] % 2;
    if (resto==0)
    {
        Console.WriteLine("Os números pares da posição " + i + "º vetor é=" + n[i]);
    }
}