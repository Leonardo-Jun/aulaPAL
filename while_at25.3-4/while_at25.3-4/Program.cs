double cont = 100, r=0;
while(cont<=500)
{
    r = cont % 3;
    if (r == 0)
    {
        Console.WriteLine("Os números múltiplo de 3 são " + cont);
    }
        cont++;
}