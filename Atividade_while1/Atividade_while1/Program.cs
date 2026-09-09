int cont = 1, n=0 ,r=0;
while(cont<=5)
{
    Console.WriteLine("Digite um número:");
    n = int.Parse(Console.ReadLine());
    r += n;
    cont++;
}
Console.WriteLine("O resultado da soma é de " + r);