int[] valor = new int[15];
int soma=0;
for (int i = 0;i<15;i++)
{
    Console.WriteLine("Digite o valor do produto da posição " + i + "° do vetor:");
    valor[i] = int.Parse(Console.ReadLine());
}
for(int i=0;i<15;i++)
{
    soma = soma + valor[i];
    Console.WriteLine("O valor do produto da posição " + i + "° do vetor é=" + valor[i]);
}
Console.WriteLine("A soma dos valores dos vetores são igual a "+soma);