int[] idade = new int[14];
double r;
for(int i=0;i<14;i++)
{
    Console.WriteLine("Digite a idade da pessoa da posição " + i + "° do vetor:");
    idade[i] = int.Parse(Console.ReadLine());
}
for(int i=0;i<14;i++)
{
    r = idade[i] % 2;
    if(r!=0)
    {
        Console.WriteLine("A idade da pessoa da posição " + i + "° do vetor é=" + idade[i]);
    }
}