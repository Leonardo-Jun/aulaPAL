//criar vetores de string
string[] nome = new string[3];
//criar vetor de inteiros
int[] idade = new int[3];

//para guardar valores
for(int i=0;i<3;i++)
{
    Console.WriteLine("Digite o nome da posição " + i + "º vetor");
    nome[i] = Console.ReadLine();
    Console.WriteLine("Digite a idade da posição " + i + "º vetor");
    idade[i] = int.Parse(Console.ReadLine());
}

//para mostrar valores
for(int i=0;i<3; i++)
{
    Console.WriteLine("O nome da posição " + i + "º do vetor é=" + nome[i]);
    Console.WriteLine("A idade da posição " + i + "º do vetor é=" + idade[i]);
}