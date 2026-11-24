int[] idade = new int[9];
double[] altura = new double[9];
double[] peso=new double[9];
for (int i = 0;i<9;i++)
{
    Console.WriteLine("Digite o peso da pessoa da posição " + i + "° do vetor:");
    peso[i] = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a altura da pessoa da posição " + i + "° do vetor:");
    altura[i] = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a idade da pessoa da posição " + i + "° do vetor:");
    idade[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < 9; i++)
{
    Console.WriteLine("O peso da pessoa da posição " + i + "° do vetor é="+peso[i]);
    Console.WriteLine("A altura da pessoa da posição " + i + "° do vetor é=" + altura[i]);
    Console.WriteLine("A idade da pessoa da posição " + i + "° do vetor é=" + idade[i]);
}
