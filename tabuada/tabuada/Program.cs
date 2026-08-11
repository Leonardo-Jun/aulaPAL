double n, r;
Console.WriteLine("Digite um número para fazer a tabuada do número:");
n = double.Parse(Console.ReadLine());
for (int i=1;i<=10;i++)
{
    r = n * i;
    Console.WriteLine(n + " x " + i + " ="+r);
}
