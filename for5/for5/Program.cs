double n, m;
for(int i=1;i<=10;i++)
{
    Console.WriteLine("Digite um número:");
    n = double.Parse(Console.ReadLine());
    m = n / 2;
    Console.WriteLine("O resultado do número pela metade é de " + m);
}
