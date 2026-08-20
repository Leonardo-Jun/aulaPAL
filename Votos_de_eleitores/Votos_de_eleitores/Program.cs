int b = 0, n=0 , v , e=0 , r =0 , t=0;
for(int i=1;i<=10;i++)
{
    Console.WriteLine("DIgite seu voto(0|1|2|3|Qualquer número):");
    v = int.Parse(Console.ReadLine());
    switch(v)
    {
        case 1:
            e = e + 1;
            break;
        case 2:
            r = r + 1;
            break;
        case 3:
            t = t + 1;
            break;
        case 0:
            b = b + 1;
            break;
        default:
            n = n + 1;
            break;
    }
}
Console.WriteLine("O total de votos do primeiro candidato é de "+e);
Console.WriteLine("O total de votos do segundo candidato é de "+r);
Console.WriteLine("O total de votos do terceiro candidato é de "+t);
Console.WriteLine("O total de votos brancos é de "+b);
Console.WriteLine("O total de votos nulos são de "+n);