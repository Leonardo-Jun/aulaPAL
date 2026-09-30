double cont = 500, resto;
while(cont>=1)
{
    resto = cont % 2;
    if(resto!=0)
    {
        Console.WriteLine("Os números ímpares de 500 a 1 é de " + cont);
    }
    cont--;
}