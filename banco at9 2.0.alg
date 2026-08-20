algoritmo "banco"
// Função :
// Autor :
// Data : 02/04/2026
// Seção de Declarações 
var
valoratrasado , valor , taxa , tempo : real
inicio
Escreva("Digite a quantidade de meses em atraso : " )
Leia(tempo)
Escreva("Digite o valor da parcela : ")
Leia(valor)
Escreva("Digite o valor da taxa de juros compostos : ")
Leia(taxa)
valoratrasado<-valor+(valor*(taxa/100)*tempo)
Escreval("O valor atrasado é de :  " , valoratrasado)
se(valoratrasado>1000)entao
  Escreval("Atenção você está com débito com o banco " )
senao
  se(valoratrasado<1000)entao
    Escreval("Cuidado você está com uma pequena divida com o banco " )
  fimse
fimse
fimalgoritmo
