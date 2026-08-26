int cont = 1, n , m;
while(cont<=3)
{
    Console.WriteLine("Digite um número:");
    n = int.Parse(Console.ReadLine());
    m = n * 7;
    Console.WriteLine("O resultado da multiplicação por sete é de " + m);
    cont++;
}