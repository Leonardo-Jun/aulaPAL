int n;
double r;
for (int i = 0; i <= 15; i++)
{
    Console.WriteLine("Digite um número:");
    n = int.Parse(Console.ReadLine());
    r = n % 6;
    if(r==0)
    {
        Console.WriteLine("O número é múltiplo de 6:" + n);
    }
}
