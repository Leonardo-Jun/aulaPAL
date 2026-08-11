int n , soma=0;
for(int i=1;i<=10;i++)
{
    Console.WriteLine("Digite um número:");
    n = int.Parse(Console.ReadLine());
    soma = n+soma;
    Console.WriteLine("O resultado da soma é de " + soma);
}
