double salbase, valorsm, inss=0, insa1=0, peri1=0, adn1=0, sb=0, sl=0, taxa=0;
int ano, horas;
string n, peri, insa, adn, mes;
Console.WriteLine("Digite o nome do funcionário:");
n= Console.ReadLine();
Console.WriteLine("Digite o salário base do funcionário:");
salbase=double.Parse(Console.ReadLine());
Console.WriteLine("Digite o salário mínino do funcionário:");
valorsm = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o mês por extenso referente ao pagamento:");
mes = Console.ReadLine();
Console.WriteLine("Digite o ano referente ao pagamento:");
ano = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade de horas extras feitas:");
horas = int.Parse(Console.ReadLine());
Console.WriteLine("Escolha uma das duas opções abaixo sobre a periculosidade!");
Console.WriteLine("Sim||Não");
peri = Console.ReadLine();
Console.WriteLine("Escolha uma das opções abaixo para o tipo de insalubridade");
Console.WriteLine("Mínimo||Médio||Máximo||Não tem");
insa = Console.ReadLine();
Console.WriteLine("Escreva se tem um adicional noturno sim ou não:");
adn = Console.ReadLine();
switch(insa)
{
    case "Mínimo": case "mínimo":
        insa1 = (valorsm * 10) / 100;
        break;
    case "Médio": case "médio":
        insa1 = (valorsm *20) / 100;
        break;
    case "Máximo": case "máximo":
        insa1 = (valorsm * 30) / 100;
        break;
    case "Não tem": case "não tem":
        insa1 = 0;
        break;
    default:
        insa1 = 0;
        break;
}
if(peri=="sim")
{
    peri1 = (salbase * 30) / 100;
}
else if(peri=="não")
{
    peri1 = 0;
}
taxa = (salbase + insa1 + peri1) / 220 * 1.5 * horas;
if (adn == "sim")
{
    adn1 = (salbase * 20) / 100;
}
else if(adn == "não")
        {
    adn1 = 0;
}
sb = salbase + taxa + insa1 + peri1 + adn1;
if(sb<=1174.86)
{
    inss = (sb * 8) / 100;
}
else if(sb>=1174.87 && sb<=1958.10)
{
    inss = (sb * 9) / 100;
}
else if (sb >= 1958.11 && sb <= 3916.20)
{
    inss = (sb * 11) / 100;
}
else if (sb > 3916.21)
{
    inss = (3916.20 * 11) / 100;
}
sl = sb - inss;
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("=====DADOS INFORMADOS=====");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Nome do funcionário:" + n);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Mês de referência:"+mes+"/"+ano);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Salário base:"+salbase);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Salário mínimo:"+valorsm);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Horas extras:"+horas);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Periculosidade:"+peri);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Insalubridade:"+insa);
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Adicional noturno:"+adn);
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("=====CÁLCULOS DO FUNCIONÁRIO=====");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Valor da insalubridade:"+ Math.Round(insa1,2));
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Valor da periculosidade:"+ Math.Round(peri1, 2));
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Valor hora extra:"+ Math.Round(taxa, 2));
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Adicional noturno:"+ Math.Round(adn1, 2));
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Salário bruto:"+ Math.Round(sb, 2)); 
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Desconto INSS:"+ Math.Round(inss, 2)); 
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Salário líquido"+ Math.Round(sl, 2));
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("================FIM DA FOLHA DE PAGAMENTO================");