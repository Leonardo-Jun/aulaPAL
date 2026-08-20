algoritmo "tabelaMédica"
// Função :
// Autor :
// Data : 25/03/2026
// Seção de Declarações 
var
sexo : caracter
altura , pesoideal : real
inicio
Escreva("Digite o sexo da pessoa : " )
Leia(sexo)
Escreva("Digite a altura da pessoa : " )
Leia(altura)
se(sexo="m")entao
pesoideal<-(62.1*altura)-44.7
  Escreva("O peso ideal para a mulher será de : " , pesoideal )
senao
  se(sexo="h") entao
  pesoideal<-(72.7*altura)-58
    Escreva("O peso ideal do homem será de : " , pesoideal )
  fimse
fimse
fimalgoritmo
