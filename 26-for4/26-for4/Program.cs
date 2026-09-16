int n, soma=0;
Console.WriteLine("Digite um número:");
n = int.Parse(Console.ReadLine());
for(int i=1;i<=n;i++)
{
    soma = soma + i;
    Console.WriteLine(i);
}
Console.WriteLine("A soma dos números de 1 a " + n + " é de " + soma);