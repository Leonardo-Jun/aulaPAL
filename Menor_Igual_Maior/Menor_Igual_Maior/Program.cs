int n;
for(int i = 1; i <= 12; i++)
{
    Console.WriteLine("Digite um número:");
    n = int.Parse(Console.ReadLine());
    if(n < 0)
    {
        Console.WriteLine("O número é menor que zero");
    }
    else if(n==0)
    {
        Console.WriteLine("O número é igual a zero");
    }
    else if(n>0)
    {
        Console.WriteLine("O número é maior que zero");
    }
}