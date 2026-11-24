int[] n = new int[5];
int soma=0;
double media;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite um número da posição " + i + "° do vetor:");
    n[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < 5; i++)
{
    soma = soma + n[i];
}
media = soma / 5;
Console.WriteLine("A média dos vetores é=" + media);