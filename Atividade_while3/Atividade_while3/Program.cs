double cont = 1, n, r;
while(cont<=3)
{
    Console.WriteLine("Digite um número:");
    n=double.Parse(Console.ReadLine());
    r = n * 6;
    Console.WriteLine("O resultado da multiplicação do número é de " + r);
    cont++;
}