int[] idade = new int[10];
for(int i=0;i<10;i++)
{
    Console.WriteLine("Digite a idade do/a aluno/a da posição " + i + "° do vetor:");
    idade[i] = int.Parse(Console.ReadLine());
}
for(int i=0;i<10;i++)
{
    if (idade[i]>14)
    {
        Console.WriteLine("A idade do/a aluno/a da posição " + i + "° do vetor é=" + idade[i]);
    }
}