int cont = 1, an, aa, idade;
while(cont<=5)
{
    Console.WriteLine("DIgite o seu ano de nascimento:");
    an=int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o ano atual:");
    aa=int.Parse(Console.ReadLine());
    idade = aa - an;
    Console.WriteLine("A sua idade é " + idade);
    cont++;
}