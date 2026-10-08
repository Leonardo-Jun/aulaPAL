string[] cor = new string[15];
for(int i=0;i<15;i++)
{
    Console.WriteLine("Digite a cor da posição :" + i + "º do vetor");
    cor[i] = Console.ReadLine();
}
for(int i = 0; i < 15; i++)
{
    Console.WriteLine("A cor da posição " + i + "º do vetor é=" + cor[i]);
}