double cont = 10, n=0 , d;
Console.WriteLine("Digite um número:");
n = double.Parse(Console.ReadLine());
while(cont<=n)
{
    d = cont / 3;
    Console.WriteLine("O resultado da divisão é de " + d);
    cont++;
}