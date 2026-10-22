int[] n = new int[25];
double resto,soma=0;
for (int i = 0; i <25; i++)
{
    Console.WriteLine("Digite um número:");
    n[i] = int.Parse(Console.ReadLine());
    resto = n[i] % 2;
    if (resto == 0)
    {
        soma = soma + 1;
    }
}
Console.WriteLine("A quantidade de números pares são de " + soma);