double[] valor = new double[15];
for(int i=0;i<15;i++)
{
    Console.WriteLine("Digite o valor do produto:");
    valor[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < 15; i++)
{
    Console.WriteLine("O valor do produto é igual a " + valor[i]);
}