int[] n = new int[20];
double resto,soma=0;
for(int i=0;i<20;i++)
{
    Console.WriteLine("Digite um número:");
    n[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < 20; i++)
{
    resto = n[i] % 2;
    if (resto != 0)
    {
        Console.WriteLine("O número da posição " + i + "º do vetor que é impar é=" + n[i]);
    }
    else if (resto == 0)
    {
        soma = soma + 1;
    }
}
Console.WriteLine("A quantidade de números pares são de " + soma);