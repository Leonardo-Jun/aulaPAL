int[] n = new int[10];
double resto, soma = 0;
for(int i=0;i<10;i++)
{
    Console.WriteLine("Digite um número:");
    n[i] = int.Parse(Console.ReadLine());
    resto = n[i] % 3;
    if(resto==0)
    {
        soma = soma + n[i];
    }
}
Console.WriteLine("O resultado da soma dos números do vetor é de " + soma);