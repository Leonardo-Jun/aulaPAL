int cont = 1;
double resto;
while(cont<=700)
{
    resto = cont % 2;
    if(resto!=0)
    {
        Console.WriteLine("Número impar:"+cont);
    }
    cont++;
}