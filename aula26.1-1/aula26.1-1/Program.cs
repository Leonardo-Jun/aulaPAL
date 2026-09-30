int cont = 1 ,n;
while(cont<=22)
{
    Console.WriteLine("Digite um número:");
    n = int.Parse(Console.ReadLine());
    if(n>0)
    {
        Console.WriteLine("O número " + n + " é maior que zero");
    }
    else if(n<0)
    {
        Console.WriteLine("O número " + n + " é menor que zero");
    }
    else if(n==0)
    {
        Console.WriteLine("O número " + n + " é igual que zero");
    }
    cont++;
}