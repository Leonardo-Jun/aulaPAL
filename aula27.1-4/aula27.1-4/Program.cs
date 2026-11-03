int[] n = new int[20];
double resto;
for(int i=0;i<20;i++)
{
    Console.WriteLine("Digite um número:");
    n[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < 20; i++)
{
    resto = n[i] % 5;
    if(resto==0)
    {
        Console.WriteLine("O número múltiplo de 5 é de " + n[i]);
    }
}