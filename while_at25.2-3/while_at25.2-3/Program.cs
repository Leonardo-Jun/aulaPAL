int cont = 1 , resto=0;
while (cont<=500)
{
    resto = cont % 2;
    if(resto==0)
    {
        Console.WriteLine("o número par:"+cont);
    }
    cont++;
}