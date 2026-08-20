int p=0 , v=0 , n=0;
for(int i=1;i<=15;i++)
{
    Console.WriteLine("DIgite um número:");
    n = int.Parse(Console.ReadLine());
    n = n % 2;
    if (n == 0)
    {
        p = p + 1;
    }
    else
    {
        v = v + 1;
    }
}
Console.WriteLine("A quantidade total de números pares é de " + p);
Console.WriteLine("A quantidade total de números ímpares é de " + v);