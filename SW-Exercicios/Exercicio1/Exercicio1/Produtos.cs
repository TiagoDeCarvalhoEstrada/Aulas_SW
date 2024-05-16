using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Produtos
    {
        // Propriedades da classe
        public string nome; // Nome do produto
        public double preco; // Preço do produto
        public int quantidadeEmEstoque; // Quantidade disponível em estoque

        // Construtor da classe Produto
        public Produtos(string nome, double preco, int quantidadeEmEstoque)
        {
            this.nome = nome; // Atribui o nome passado como parâmetro à propriedade nome
            this.preco = preco; // Atribui o preço passado como parâmetro à propriedade preco
            this.quantidadeEmEstoque = quantidadeEmEstoque; // Atribui a quantidade passada como parâmetro à propriedade quantidadeEmEstoque
        }

        // Método para adicionar itens ao estoque
        public void AdicionarItemNoEstoque(int quantidade)
        {
            if (quantidade > 0) // Verifica se a quantidade a ser adicionada é maior que zero
            {
                quantidadeEmEstoque += quantidade; // Incrementa a quantidade em estoque
                                                   // Exibe uma mensagem informando a adição de itens no estoque
                Console.WriteLine($"{quantidade} unidades de {nome} adicionadas no estoque. Novo estoque: {quantidadeEmEstoque} unidades.");
            }
            else
            {
                Console.WriteLine("A quantidade adicionada deve ser maior que zero!"); // Exibe uma mensagem de erro
            }
        }

        // Método para remover itens do estoque
        public void RemoverItemDoEstoque(int quantidade)
        {
            if (quantidade > 0 && quantidade <= quantidadeEmEstoque) // Verifica se a quantidade a ser removida é válida
            {
                quantidadeEmEstoque -= quantidade; // Decrementa a quantidade em estoque
                                                   // Exibe uma mensagem informando a remoção de itens do estoque
                Console.WriteLine($"{quantidade} unidades de {nome} removidas do estoque. Novo estoque: {quantidadeEmEstoque} unidades.");
            }
            else if (quantidade > quantidadeEmEstoque) // Verifica se a quantidade a ser removida é maior que a quantidade em estoque
            {
                Console.WriteLine("A quantidade a ser removida é maior do que a quantidade em estoque."); // Exibe uma mensagem de erro
            }
            else
            {
                Console.WriteLine("A quantidade adicionada deve ser maior que zero!"); // Exibe uma mensagem de erro
            }
        }
    }
}
