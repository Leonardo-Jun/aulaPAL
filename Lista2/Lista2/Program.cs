double resto=0 , m=0;
for (int i=1;i<=300;i++)
{
    resto = i % 3;
    if (resto == 0)
    {
        Console.WriteLine("O " +i+ " é multiplo do 3");
        m=m+1;
    }
    else
    {
        Console.WriteLine("O "+i+" não é multiplo do 3");
    }
}
Console.WriteLine("A quantidade de números multiplo de três:" + m);