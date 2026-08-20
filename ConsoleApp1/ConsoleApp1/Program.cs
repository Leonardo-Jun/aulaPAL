int soma=0 ;
for(int i=1;i<=50;i++)
{
    if(i%3 ==0)
    {
        soma = soma + i;
    }
}
Console.WriteLine("O resultado da soma dos multiplos de 3 é de " + soma);