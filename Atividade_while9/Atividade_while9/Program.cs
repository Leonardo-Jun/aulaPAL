int cont = 1, a = 0, b = 0, c = 0,soma=0;
string n, t, s;
while(cont<=30)
{
    Console.WriteLine("Digite a resposta da primeira questão:");
    n =(Console.ReadLine());
    Console.WriteLine("Digite a resposta da segunda questão:");
    t =(Console.ReadLine());
    Console.WriteLine("Digite a resposta da terceira questão:");
    s =(Console.ReadLine());
    if(n=="A"||n=="a")
    {
        a = a + 1;
    }
    else { }
    if (t == "C" || t == "c")
    {
        b = b + 1;
    }
    else { }
    if (s == "D" || s == "d")
    {
        c = c + 1;
    }
    else { }
    soma = a + b + c;
        cont++;
}
Console.WriteLine("O total de pontos da primeira questão é de "+a);
Console.WriteLine("----------------------------------------------");
Console.WriteLine("O total de pontos da segunda questão é de " + b);
Console.WriteLine("----------------------------------------------");
Console.WriteLine("O total de pontos da terceira questão é de " + c);
Console.WriteLine("----------------------------------------------");
Console.WriteLine("O total de pontos das questões é de " + soma);