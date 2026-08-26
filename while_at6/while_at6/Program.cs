int cont = 800, par=0, r=0;
while(cont>=1)
{
    r = cont % 2;
    if(r!=0)
    {
        Console.WriteLine(cont);
    }
    else if(r==0)
    {
        par += cont;
    }
        cont--;
}
Console.WriteLine("A soma dos números pares é de " + par);