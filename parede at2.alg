algoritmo "parede"
// Função :
// Autor :
// Data : 31/03/2026
// Seção de Declarações 
var
altparede , largparede , altazulejo , largazulejo , areaparede , areaazulejo , quanazulejo : real
inicio
Escreva("Digite o valor da altura da parede: " )
Leia(altparede)
Escreva("Digite o valor da largura da parede : " )
Leia(largparede)
Escreva("Digite o valor da altura do azulejo : " )
Leia(altazulejo)
Escreva("Digite o valor da largura do azulejo : " )
Leia(largazulejo)
areaparede<-largparede*altparede
areaazulejo<-largazulejo*altazulejo
quanazulejo<-areaparede/areaazulejo
Escreva("A quantidade necessária de azulejos para a parede é de : " , quanazulejo)
fimalgoritmo
