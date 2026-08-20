algoritmo "supermercado"
// Função :
// Autor :
// Data : 31/03/2026
// Seção de Declarações 
var
nome : caracter
quan_comprar , quan_max , quan_estoque : real
inicio
Escreva("Digite o nome do produto : " )
Leia(nome)
Escreva("Digite quantidade máxima do produto : " )
Leia(quan_max)
Escreva("Digite a quantidade que se tem no estoque : " )
Leia(quan_estoque)
quan_comprar<-quan_max-quan_estoque
Escreva("A quantia a ser comprada é de : " , quan_comprar)
fimalgoritmo
