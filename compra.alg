algoritmo "produto"
// Função :
// Autor :
// Data : 25/03/2026
// Seção de Declarações 
var
 nome_produto: caractere
   qtd_maxima, qtd_estoque, qtd_comprar: inteiro

Inicio

   escreva("Digite o nome do produto: ")
   leia(nome_produto)

   escreva("Digite a quantidade máxima desejada: ")
   leia(qtd_maxima)

   escreva("Digite a quantidade em estoque: ")
   leia(qtd_estoque)

   qtd_comprar <- qtd_maxima - qtd_estoque

   se (qtd_comprar > 0) entao
      escreva("Produto: ", nome_produto)
      escreva("Quantidade a comprar: ", qtd_comprar)
   senao
      escreva("Produto: ", nome_produto)
      escreva("Não é necessário comprar este produto:")
   fimse


fimalgoritmo
