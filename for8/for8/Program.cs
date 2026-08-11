int idade;
string sexo, n;
for(int i=1;i<=3;i++)
{
    Console.WriteLine("Digite o nome:");
    n = Console.ReadLine();
    Console.WriteLine("Digite o sexo (masculino ou femenino):");
    sexo = Console.ReadLine();
    Console.WriteLine("Digite a idade:");
    idade = int.Parse(Console.ReadLine());
    if (sexo=="masculino"&&idade>=21)
    {
        Console.WriteLine("Nome:" + n);
    }
}

