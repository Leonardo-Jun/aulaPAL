int[] n = new int[10];
int soma=0, neg=0;
for(int i = 0;i<10;i++)
{
    Console.WriteLine("Digite um número:");
    n[i] = int.Parse(Console.ReadLine());
    if (n[i]>=0)
    {
        soma = soma + 1;
    }
    if (n[i] < 0)
    {
        neg = neg + 1;
    }
}
Console.WriteLine("A quantidade de números positivos dados pelo vetor é de " + soma);
Console.WriteLine("A quantidade de números negativos dados pelo vetor é de " + neg);