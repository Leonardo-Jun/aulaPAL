int cont = 1, ano, nasc, idade;
while(cont<=4)
{
    Console.WriteLine("Digite o ano de nascimento da pessoa:");
    nasc = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o ano atual:");
    ano = int.Parse(Console.ReadLine());
    idade = ano - nasc;
    Console.WriteLine("A idade da pessoa é de " + idade);
    cont++;
}