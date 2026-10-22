string[] nome = new string[5];
double[] peso = new double[5];
    for(int i=0;i< 5;i++)
    {
    Console.WriteLine("Digite o nome do paciente:");
    nome[i] = Console.ReadLine();
    Console.WriteLine("Digite o peso do paciente:");
    peso[i] = double.Parse(Console.ReadLine());
}
for (int i = 0; i < 5; i++)
{
    if (peso[i] > 85)
    {
        Console.WriteLine("O nome da posição " + i + "º do vetor é=" + nome[i]);
        Console.WriteLine("O peso da posição " + i + "º do vetor é=" + peso[i]+" kg");
    }
}