int idade , q=0;
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Digite a idade da pessoa:");
    idade = int.Parse(Console.ReadLine());

    if (idade >= 18)
    {
        q = q + 1;
    }
}
Console.WriteLine("A quantidade de pessoas maiores de 18 anos é de " + q);
