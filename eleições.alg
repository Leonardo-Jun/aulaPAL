algoritmo "eleicoes"
// Função :
// Autor :
// Data : 12/03/2026
// Seção de Declarações 
var
totaleleitores , vb , vv , vn : inteiro
percbranco , percvalidos , percnulos : real
inicio
Escreva("Digite a quantidade de votos brancos :")
Leia(vb)
Escreva("Digite a quantidade de votos válidos :")
Leia(vv)
Escreva("Digite a quantidade de votos nulos :")
Leia(vn)
totaleleitores<-vb+vv+vn
percbranco<-(vb*100)/totaleleitores
percvalidos<-(vv*100)/totaleleitores
percnulos<-(vn*100)/totaleleitores
Escreval("A quantidade total de eleitores são de : " , totaleleitores)
Escreval("O percentual de votos válidos são de : " , percvalidos)
Escreval("O percentual de votos brancos são de : " , percbranco)
Escreval("O percentual de votos nulos são de : " , percnulos)
fimalgoritmo
