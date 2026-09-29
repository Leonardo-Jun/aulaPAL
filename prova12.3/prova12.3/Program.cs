string nome, sexo;
int cont = 1;
while(cont<=30)
{
    Console.WriteLine("Digite seu nome:");
    nome = Console.ReadLine();
    Console.WriteLine("Digite seu sexo(F/M):");
    sexo = Console.ReadLine();
    if (sexo == "F")
    {
        Console.WriteLine("Você não precisa fazer o exame");
    }
    else if(sexo=="M")
    {
        Console.WriteLine(nome + " precisa fazer o exame");
    }
    else
    {
        Console.WriteLine("Digite F ou M");
    }
    cont++;
}