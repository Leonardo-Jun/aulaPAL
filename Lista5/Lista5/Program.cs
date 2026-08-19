string g;
double a, qua = 0;
for(int i = 1;i<=4;i++)
{
    Console.WriteLine("Digite o sexo da pessoa(M|F):");
    g = Console.ReadLine();
    Console.WriteLine("DIgite a altura da pessoa:");
    a = double.Parse(Console.ReadLine());
    if(g=="F")
    {
        Console.WriteLine("A altura da mulher é de " + a+ "m");
    }
    else if(g=="M")
    {
        qua = qua + 1;
    }
}
Console.WriteLine("A quantidade de homens é de " + qua);




