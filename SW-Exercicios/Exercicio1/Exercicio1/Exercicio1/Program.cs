namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exibe uma mensagem para o usuário
            Console.WriteLine("***** Adicionar e Remover Produtos *****");

            // Solicita ao usuário para informar os dados do produto
            Console.WriteLine("Informe os dados do produto: ");

            // Solicita e obtém o nome do produto do usuário
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            // Solicita e obtém o preço do produto do usuário
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());

            // Solicita e obtém a quantidade em estoque do produto do usuário
            Console.Write("Quantidade em Estoque: ");
            int quantidadeEmEstoque = int.Parse(Console.ReadLine());

            // Cria um novo objeto Produto com os dados fornecidos pelo usuário
            Produtos produto = new Produtos(nome, preco, quantidadeEmEstoque);

            // Exibe uma linha em branco para melhorar a legibilidade
            Console.WriteLine();

            // Exibe uma mensagem indicando o início do processo de adição de itens ao estoque
            Console.WriteLine("----- Estoque -----");

            // Exibe uma linha em branco para melhorar a legibilidade
            Console.WriteLine();

            // Solicita ao usuário para adicionar itens ao estoque e obtém a quantidade informada
            Console.WriteLine("Adicione itens ao estoque: ");
            int adicionarItem = int.Parse(Console.ReadLine());

            // Chama o método AdicionarItemNoEstoque do objeto produto para adicionar itens ao estoque
            produto.AdicionarItemNoEstoque(adicionarItem);

            // Exibe uma linha em branco para melhorar a legibilidade
            Console.WriteLine();

            // Solicita ao usuário para remover itens do estoque e obtém a quantidade informada
            Console.WriteLine("Remova itens do estoque: ");
            int removerItem = int.Parse(Console.ReadLine());

            // Chama o método RemoverItemDoEstoque do objeto produto para remover itens do estoque
            produto.RemoverItemDoEstoque(removerItem);

            // Aguarda o usuário pressionar uma tecla antes de fechar a aplicação
            Console.ReadKey();
        }
    }
}
