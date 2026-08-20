algoritmo "azulejos"
// Função :
// Autor :
// Data : 19/03/2026
// Seção de Declarações 
var
quanazulejos , alturaparede , larguraparede , alturaazulejo , larguraazulejo , areaparede , areaazulejo : real
inicio
Escreva("Digite a altura que a parede tem : ")
Leia(alturaparede)
Escreva("Digite a largura que a parede tem : " )
Leia(larguraparede)
Escreva("Digite a altura do azulejo : " )
Leia(alturaazulejo)
Escreva("Digite a largura do azulejo : " )
Leia(larguraazulejo)
areaparede<-alturaparede*larguraparede
areaazulejo<-alturaazulejo*larguraazulejo
quanazulejos<-areaparede/areaazulejo
Escreva("A quantidade de azulejos necessário para azulejar a parede é de : " , quanazulejos)

fimalgoritmo
