double[] altura = new double[5];
string[] sexo = new string[5];
int soma = 0;
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Digite a altura da pessoa:");
    altura[i] = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o sexo da pessoa(M|F):");
    sexo[i] =Console.ReadLine();
}
for (int i = 0; i < 5; i++)
{
    if (sexo[i] == "F")
    {
        Console.WriteLine("A mulher da posição " + i + "º do vetor tem a altura igual a =" + altura[i] + " m");
    }
    else if (sexo[i] == "M")
    {
        soma = soma + 1;
    }
}
Console.WriteLine("A quantidade de homens é de " + soma);