int n , p=0, cont = 1 ,r=0;
while (cont <= 15)
{
    Console.WriteLine("Digite um número:");
    n = int.Parse(Console.ReadLine());
    r = n % 2;
    if (r == 0)
    {
        p = p +1 ;
    }
    cont++;
}
Console.WriteLine(p);