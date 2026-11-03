string[] n1 = new string[5];
string[] n2 = new string[5];
for(int i=0;i<5;i++)
{
    Console.WriteLine("Digite o nome do paciente:");
    n1[i] = Console.ReadLine();
    Console.WriteLine("Digite o nome do médico:");
    n2[i] = Console.ReadLine();
}
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("O nome do paciente é " + n1[i]);
    Console.WriteLine("O nome do médico é " + n2[i]);
}