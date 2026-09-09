double cont = 0, n = 0, r=0;
Console.WriteLine("Digite um número:");
n = double.Parse(Console.ReadLine());
while(cont<=n)
{
    r = cont * 2;
    Console.WriteLine("O resultado do dobro do número é de " + r);
    cont++;
}