int soma = 0, cont = 1;
while(cont<=300)
{
    soma = soma + cont;
    Console.WriteLine(cont);
    cont++;
}
Console.WriteLine("A soma dos números de 1 a 300 é de " + soma);