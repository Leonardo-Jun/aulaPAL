string[] nome = new string[10];
string[] sigla = new string[10];
for(int i=0;i<10;i++)
{
    Console.WriteLine("Digite o nome do elemento químico do " + i + "º vetor");
    nome[i] = Console.ReadLine();
    Console.WriteLine("Digite a sigla referente do " + i + "º vetor");
    sigla[i] = Console.ReadLine();
}
for(int i=0;i<10;i++)
{
    Console.WriteLine("O " + i + "º vetor do elemento químico e sua sigla:" + nome[i] + "=" + sigla[i]);
}