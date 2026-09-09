string sexo , nome;
int cont = 1;
while(cont<=15)
{
    Console.WriteLine("Digite o nome do/a funcionário/a:");
    nome = Console.ReadLine();
    Console.WriteLine("Digite o sexo(F|M):");
    sexo = Console.ReadLine();
    if(sexo=="M"||sexo=="m")
    {
        Console.WriteLine(nome + " precisa fazer o exame da empresa");
    }
    else if(sexo=="F"||sexo=="f")
    {
        Console.WriteLine(nome + " não necessita fazer o exame");
    }
    else
    {
        Console.WriteLine("O sexo foi digitado incorretamente");
    }
    cont++;
}