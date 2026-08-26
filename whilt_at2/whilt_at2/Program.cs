int cont = 0, n ;
double q;
Console.WriteLine("Digite um número:");
n = int.Parse(Console.ReadLine());
while(cont<=n)
{
    q = Math.Pow(cont, 2);
    Console.WriteLine(cont + "²=" + q); ;
    cont++;
}