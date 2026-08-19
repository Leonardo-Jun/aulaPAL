int n = 0, p=0 , r ;
for(int i=1;i<=10;i++)
{
    Console.WriteLine("Digita um número:");
     r= int.Parse(Console.ReadLine());
    if(r>0)
    {
        p=p+1;
    }
    else
    {
        n=n+1; 
    }
}
Console.WriteLine("A quantidade de positivos são:" + p);
Console.WriteLine("A quantidade de negativos são:" + n);