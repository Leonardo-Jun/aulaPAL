//criar vetor

//armazenando dados vetor
int[] vetor = new int[6];
for (int i = 0; i < 6; i++)
{
    Console.WriteLine("Digite o valor da posição " + i + "º do vetor:");
    vetor[i] = int.Parse(Console.ReadLine());
}

//mostrar dados vetor
for(int i= 0; i < 6;i++)
{
    Console.WriteLine("O valor da posição " + i + "º do vetor é " + vetor[i]);
}