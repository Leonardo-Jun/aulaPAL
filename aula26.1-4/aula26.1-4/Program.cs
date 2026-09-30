int par = 0, impar = 0, n;
double resto;
for(int i=1; i<=24;i++)
{
    Console.WriteLine("Digite um número:");
    n = int.Parse(Console.ReadLine());
    resto = n % 2;
    if(resto==0)
    {
        par = par + n;
    }
    else
    {
        {
            impar = impar + n;
        }
    }
}
Console.WriteLine("O número total de números pares são de " + par);
Console.WriteLine("O número total de números ímpares são de " + impar);