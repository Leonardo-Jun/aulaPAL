algoritmo "peso"
// Função :
// Autor :
// Data : 01/04/2026
// Seção de Declarações 
var
sexo : caracter
altura , pesoideal : real
inicio
Escreva("Digite o sexo da pessoa : " )
Leia(sexo)
Escreva("Digite a altura da pessoa ; " )
Leia(altura)
se(sexo="m")entao
  pesoideal<-(62.1*altura)-44.7
  Escreval("O peso ideal da mulher será de : " , pesoideal)
senao
  se(sexo="h")entao
    pesoideal<-(72.7*altura)-58
    Escreval("O peso ideal para o homem será de : " , pesoideal )
    fimse
fimse
fimalgoritmo
