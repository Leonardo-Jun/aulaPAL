double cont = 1, n, t;
while(cont<=3)
{
    Console.WriteLine("Digite um número:");
    n = double.Parse(Console.ReadLine());
    t = n * 9;
    Console.WriteLine("O resultado da multiplicação por 9 é " + t);
    cont++;
}