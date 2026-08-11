double n , q;
for(int i=1;i<=5;i++)
{
    Console.WriteLine("Digite um número:");
    n = double.Parse(Console.ReadLine());
    q = Math.Pow(n, 2);
    Console.WriteLine("O resultado do número ao quadrado é de " + q);
}
