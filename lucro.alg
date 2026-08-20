algoritmo "comercio"
// Função :
// Autor :
// Data : 25/03/2026
// Seção de Declarações 
var
lucro , valor : real
inicio
Escreva("Digite o valor do produto : " )
leia(valor)
se (valor<20 ) entao
  lucro<-valor+(valor*45)/100
  Escreva("O lucro será de : " , lucro )
senao
    se (valor>20) entao
     lucro<-valor+(valor*30)/100
     Escreva("O lucro será de : " , lucro)
  fimse
fimse
fimalgoritmo
