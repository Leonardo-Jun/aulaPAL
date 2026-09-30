double inicial, final,valor,resultado;
Console.WriteLine("Digite o número que quer da tabuada:");
valor = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor incial da tabuada:");
inicial = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor final da tabuada:");
final = double.Parse(Console.ReadLine());
while(inicial<=final)
{
    resultado = valor * inicial;
    Console.WriteLine(valor + "*" + inicial + "=" + resultado);
    inicial++;
}