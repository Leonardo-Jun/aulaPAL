algoritmo "Exemplo Se_Senao"
// Função :
// Autor :
// Data : 24/03/2026
// Seção de Declarações 
var
 n1 , n2 , media : real
inicio
Escreva("Digite a primeira nota : " )
leia(n1)
Escreva("Digite a segunda nota : " )
Leia(n2)
media<-(n1+n2)/2
Escreva("A média do aluno é : " , media)
se (media >= 7 ) entao
  Escreva("Aluno aprovado")
senao
  se ((media >= 5) e (media <=6)) entao
    Escreva(" Aluno Recuperação")
  senao
    Escreva("Aluno reprovado")
  fimse
fimse
fimalgoritmo
