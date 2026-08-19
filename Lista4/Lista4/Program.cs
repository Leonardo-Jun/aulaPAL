double n=0 ,o=0, r , resto;
for(int i=1;i<=15;i++)
{
    Console.WriteLine("Digite um número:");
    r = double.Parse(Console.ReadLine());
    resto = r % 2;
    if(resto==0)
    {
        n = n + 1;
    }
}
Console.WriteLine("A quantidade total de números pares é de " + n);
