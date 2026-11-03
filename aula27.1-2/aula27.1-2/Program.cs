string[] vogal = new string[5];
for(int i = 0;i<5;i++)
{
    Console.WriteLine("Digite as vogais do alfabeto:");
    vogal[i] = Console.ReadLine();
}
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("A vogal armazenada é " + vogal[i]);
}