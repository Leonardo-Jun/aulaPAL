double cont = 1, q, n;
while(cont<=9)
{
    Console.WriteLine("Digite um número:");
    n = double.Parse(Console.ReadLine());
    q = Math.Pow(n, 2);
    Console.WriteLine(n + "²=" + q);
    cont++;
}