double cont = 1, n = 0 , m=0;
Console.WriteLine("Digite um número:");
n = double.Parse(Console.ReadLine());
while (cont <= 30)
{
    m = n * cont;
    Console.WriteLine("a tabuada do " + n + " é igual a " + m);
    cont++;
}