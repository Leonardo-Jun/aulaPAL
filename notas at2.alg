algoritmo "aluno"
// Função :
// Autor :
// Data : 01/04/2026
// Seção de Declarações 
var
nota1_a1 , nota2_a1 , nota3_a1 , nota1_a2 , nota2_a2 , nota3_a2 , media1 , media2: real
nome1 , nome2 : caracter
inicio
Escreva("Digite o nome do primeiro aluno : " )
Leia(nome1)
Escreva("Digite o nome do segundo aluno : " )
Leia(nome2)
Escreva("Digite a primeira nota do primeiro aluno : " )
Leia(nota1_a1)
Escreva("Digite a segunda nota do primeiro aluno : " )
Leia(nota2_a1)
Escreva("Digite a terceira nota do primeiro aluno : " )
Leia(nota3_a1)
Escreva("Digite a primeira nota do segundo aluno : " )
Leia(nota1_a2)
Escreva("Digite a segunda nota do segundo aluno : " )
Leia(nota2_a2)
Escreva("Digite a terceira nota do segundo aluno : " )
Leia(nota3_a2)
media2<-(nota1_a2+nota2_a2+nota3_a2)/3
media1<-(nota1_a1+nota2_a1+nota3_a1)/3
se(media1>media2)entao
  Escreval(nome1 , " tem a maior média que é de : " , media1)
senao
  se(media1<media2)entao
     Escreval(nome2 , " tem a maior média que é de : " , media2)
     fimse
fimse
fimalgoritmo
