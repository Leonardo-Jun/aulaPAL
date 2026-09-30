double n, resto,soma=0;
for (int i = 1; i <= 15; i++)
{
    Console.WriteLine("Digite um número:");
    n = double.Parse(Console.ReadLine());
    resto = n % 6;
    if(resto==0)
    {
        soma = soma + 1;
    }
}
Console.WriteLine("A quantidade total de números múltiplos de 6 é de " + soma);