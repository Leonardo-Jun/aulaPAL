double cont = 1,n , r1,r2,r3;
while(cont<=20)
{
    Console.WriteLine("Digite um número:");
    n = double.Parse(Console.ReadLine());
    r1 = n % 3;
    r2 = n % 4;
    r3 = n % 5;
    if(r1==0)
    {
        Console.WriteLine("O número " + n + " é múltiplo de 3");
    }
    if (r2 == 0)
    {
        Console.WriteLine("O número " + n + " é múltiplo de 4");
    }
    if (r3 == 0)
    {
        Console.WriteLine("O número " + n + " é múltiplo de 5");
    }
    cont++;
}