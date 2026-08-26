int cont = 1, n , soma=0;
Console.WriteLine("Digite um número:");
n = int.Parse(Console.ReadLine());
while(cont<=n)
    {
    soma += cont;
    cont++; 
}
Console.WriteLine("A soma dos números deu " + soma);