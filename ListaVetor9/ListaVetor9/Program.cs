string[] esporte = new string[12];
for(int i=0;i<12;i++)
{
    Console.WriteLine("Digite o nome da modalidade esportiva:");
    esporte[i] = Console.ReadLine();
}
for (int i = 0; i < 12; i++)
{
    Console.WriteLine("A modalidade da posição " + i + "º do vetor é=" + esporte[i]);

}