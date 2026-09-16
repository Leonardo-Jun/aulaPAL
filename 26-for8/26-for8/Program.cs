int n;
double s;
Console.WriteLine("Digite um número:");
n = int.Parse(Console.ReadLine());
for(int i=1;i<=20;i++)
{
    s = n * i;
    Console.WriteLine(n + "*" + i + "=" + s);
}