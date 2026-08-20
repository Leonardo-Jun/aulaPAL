algoritmo "eleitores"
// Função :
// Autor :
// Data : 18/03/2026
// Seção de Declarações 
var
totaleleitores , faixa1 , faixa2 , percfaixa1 , percfaixa2 : real
inicio
Escreva("Digite os votos f1: " )
Leia(faixa1)
Escreva("Digite os votos f2: " )
Leia(faixa2)
totaleleitores<-faixa1+faixa2
percfaixa1<-(faixa1*100)/totaleleitores
percfaixa2<-(faixa2*100)/totaleleitores
Escreval("O total de votos dos eleitores são de : " , totaleleitores )
Escreval("O percentual dos votos da faixa 1 são de : " , percfaixa1 )
Escreval("O percentual dos votos da faixa 2 são de : " , percfaixa2 )
fimalgoritmo
