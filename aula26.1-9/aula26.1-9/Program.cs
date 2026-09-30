double cont = 1, resto,n;
while(cont<=10)
{
    Console.WriteLine("Digite um número:");
    n = double.Parse(Console.ReadLine());
    resto = n % 7;
    if(resto==0)
    {
        Console.WriteLine("O número " + n + " é múltiplo de 7");
    }
    cont++;
}