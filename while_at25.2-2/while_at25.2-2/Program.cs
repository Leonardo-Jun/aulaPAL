double cont = 1, resto = 0,
 n=0 , d , t;
while (cont<=7)
{
    Console.WriteLine("Digite um número:");
    n = double.Parse(Console.ReadLine());
    resto = n % 2;
    if(resto==0)
    {
        d = Math.Pow(n,2);
        Console.WriteLine(n + "²=" + d);
    }
    else if(resto!=0)
    {
        t = Math.Pow(n, 3);
        Console.WriteLine(n + "³=" + t);
    }
}