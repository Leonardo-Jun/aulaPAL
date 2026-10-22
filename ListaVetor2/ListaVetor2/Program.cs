int[] n = new int[16];
double resto, soma = 0;
for(int i=0;i<16;i++)
{
    Console.WriteLine("Digite um número:");
    n[i] = int.Parse(Console.ReadLine());
}
for (int i = 0;i<16;i++)
{
    resto = n[i] % 3;
    if (resto == 0)
    {
        soma = soma + 1;
        Console.WriteLine("O número da posição " + i + "º do vetor é múltiplo de 3 é=" + n[i]);
    }
}
    Console.WriteLine("A quantidade de números múltiplos de 3 é de " + soma);