algoritmo "ano"
// Função :
// Autor :
// Data : 02/04/2026
// Seção de Declarações 
var
anoatual , anodenascimento , idade : real
inicio
Escreva("Digite o ano atual : " )
Leia(anoatual)
Escreva("Digite a ano de nascimento da pessoa : " )
Leia(anodenascimento)
idade<-anoatual-anodenascimento
se(idade<16)entao
  Escreval("Não pode votar este ano" )
senao
  se(idade>16)entao
    Escreval("Pode votar este ano " )
  fimse
fimse
fimalgoritmo
