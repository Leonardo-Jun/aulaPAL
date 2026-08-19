double resto, r = 0;
for (int i=1;i<=10;i++)
{
    Console.WriteLine("Digite um número:");
    r = double.Parse(Console.ReadLine());
    resto = r % 4;
    if (resto == 0)
    {
        Console.WriteLine("O " + r + " é multiplo de 4");
    }
    else
    {
        Console.WriteLine("O " + r + " não é multiplo de 4");
    }
}

