int[] n = new int[20];
double r;
for(int i=0;i<20;i++)
{
    Console.WriteLine("digite o número da posição " + i + "° do vetor:");
    n[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < 20; i++)
{
    r = n[i] % 3;
    if (r == 0)
    {
        Console.WriteLine("O número da posição " + i + "° do veotr é=" + n[i]);
    }
}