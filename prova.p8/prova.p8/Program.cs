string[] animal = new string[6];
string[] dono = new string[6];
for (int i = 0; i < 6; i++)
{
    Console.WriteLine("Digite o nome do animal da posição " + i + "° do vetor:");
    animal[i] = Console.ReadLine();
    Console.WriteLine("Digite o nome do dono da posição " + i + "° do vetor:");
    dono[i] = Console.ReadLine();
}
for (int i = 0; i < 6; i++)
{
    Console.WriteLine("O nome do animal da posição " + i + "° do vetor é=" + animal[i]);
    Console.WriteLine("O nome do dono da posição " + i + "° do vetor é=" + dono[i]);
}