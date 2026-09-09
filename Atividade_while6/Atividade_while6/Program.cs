double cont = 1, n, r = 0,soma=0;
while (cont <= 20)
{
    Console.WriteLine("Digite um número:");
    n = double.Parse(Console.ReadLine());
    r = n % 3;
    if (r == 0)
    {
        Console.WriteLine("o número múltiplo de 3 é " + n);
        soma = soma + 1;
    }
    else
    {
        Console.WriteLine();
    }
    cont++;
}
Console.WriteLine("A quantidade de números múltiplos de 3 são " + soma);