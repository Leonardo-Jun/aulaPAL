double cont = 1, r, soma = 0;
while(cont<=750)
{
    r = cont % 4;
    if (r == 0)
    {
        Console.WriteLine("O número é múltiplo de 4:" + cont);
        soma = soma + 1;
            }
    else
    {
        Console.WriteLine();
    }
    cont++;
}
Console.WriteLine("A quantidade total de números múltiplos é de " + soma);