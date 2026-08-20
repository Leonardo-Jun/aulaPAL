algoritmo "supermercado"
// Função :
// Autor :
// Data : 19/03/2026
// Seção de Declarações 
var
quanmax , quancom , quanestq : real
nome : caracter
inicio
Escreva("Digite o nome do produto : " )
Leia(nome)
Escreva("Digite a quantidade máxima do produto : " )
Leia(quanmax)
Escreva("Digite a quantidade de produto que a no estoque : " )
Leia(quanestq)
quancom<-quanmax-quanestq
Escreva("O produto é :" ,  nome , " e se comprou  essa quantidade  : " , quancom)
fimalgoritmo
