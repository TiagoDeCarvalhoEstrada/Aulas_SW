using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio6
{
    public class Produto // Definição da classe Produto
    {
        public int codigo; // Código do produto
        public string nome; // Nome do produto
        public double preco; // Preço do produto
        public int quantidadeEmEstoque; // Quantidade em estoque do produto

        // Construtor da classe Produto
        public Produto(int codigo, string nome, double preco, int quantidadeEmEstoque)
        {
            this.codigo = codigo; // Atribui o código passado como parâmetro à propriedade codigo
            this.nome = nome; // Atribui o nome passado como parâmetro à propriedade nome
            this.preco = preco; // Atribui o preço passado como parâmetro à propriedade preco
            this.quantidadeEmEstoque = quantidadeEmEstoque; // Atribui a quantidade em estoque passada como parâmetro à propriedade quantidadeEmEstoque
        }
    }

    public class GerenciadorDeProduto // Definição da classe GerenciadorDeProduto
    {
        private List<Produto> listaDeProdutos = new List<Produto>(); // Lista para armazenar os produtos

        // Construtor da classe GerenciadorDeProduto
        public GerenciadorDeProduto()
        {
            listaDeProdutos = new List<Produto>(); // Inicializa a lista de produtos
        }

        // Método para adicionar um novo produto à lista
        public void AdicionarProduto(int codigo, string nome, double preco, int quantidadeEmEstoque)
        {
            Produto novoProduto = new Produto(codigo, nome, preco, quantidadeEmEstoque); // Cria um novo objeto Produto
            listaDeProdutos.Add(novoProduto); // Adiciona o produto à lista de produtos
        }

        // Método para remover um produto da lista
        public void RemoverProduto(int codigoInformado)
        {
            Produto produtoParaRemover = listaDeProdutos.Find(p => p.codigo == codigoInformado); // Busca o produto na lista pelo código

            if (produtoParaRemover != null) // Se o produto foi encontrado
            {
                listaDeProdutos.Remove(produtoParaRemover); // Remove o produto da lista de produtos
            }
        }

        // Método para listar todos os produtos
        public List<Produto> ListarProdutos()
        {
            return listaDeProdutos; // Retorna a lista de produtos
        }

        // Método para buscar um produto pelo código
        public Produto BuscarProdutoPorCodigo(int codigoInformado)
        {
            return listaDeProdutos.Find(p => p.codigo == codigoInformado); // Retorna o produto encontrado na lista pelo código
        }
    }
}
