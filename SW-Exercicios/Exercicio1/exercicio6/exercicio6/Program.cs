namespace exercicio6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("***** Gerenciador de Produtos *****"); // Exibe um cabeçalho

            GerenciadorDeProduto gerenciador = new GerenciadorDeProduto(); // Instancia um novo objeto GerenciadorDeProduto

            // Loop para permitir que o usuário interaja com as opções do menu
            while (true)
            {
                Console.WriteLine("\nOpções:");
                Console.WriteLine("1 - Adicionar Produto");
                Console.WriteLine("2 - Listar Produtos");
                Console.WriteLine("3 - Consultar Produto por Código");
                Console.WriteLine("4 - Sair");

                Console.Write("Escolha uma opção: ");
                int escolha = int.Parse(Console.ReadLine()); // Obtém a opção escolhida pelo usuário

                switch (escolha)
                {
                    case 1: // Caso o usuário escolha adicionar um produto
                        Console.Write("Informe o código do produto: ");
                        int codigo = int.Parse(Console.ReadLine()); // Obtém o código do produto
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine(); // Obtém o nome do produto
                        Console.Write("Preço: ");
                        double preco = double.Parse(Console.ReadLine()); // Obtém o preço do produto
                        Console.Write("Quantidade em Estoque: ");
                        int quantidadeEmEstoque = int.Parse(Console.ReadLine()); // Obtém a quantidade em estoque do produto
                        gerenciador.AdicionarProduto(codigo, nome, preco, quantidadeEmEstoque); // Adiciona o produto com os dados informados
                        Console.WriteLine("Produto adicionado com sucesso."); // Exibe uma mensagem de sucesso
                        break;

                    case 2: // Caso o usuário escolha listar os produtos
                        Console.WriteLine("----- Lista de Produtos -----"); // Exibe um cabeçalho
                        var listaDeProdutos = gerenciador.ListarProdutos(); // Obtém a lista de produtos
                        foreach (var produto in listaDeProdutos) // Itera sobre os produtos na lista
                        {
                            Console.WriteLine($"Código: {produto.codigo}, Nome: {produto.nome}, Preço: {produto.preco:C}, Quantidade em Estoque: {produto.quantidadeEmEstoque}"); // Exibe os detalhes do produto
                        }
                        break;

                    case 3: // Caso o usuário escolha consultar um produto por código
                        Console.Write("Informe o código do produto a ser consultado: ");
                        int codigoConsulta = int.Parse(Console.ReadLine()); // Obtém o código do produto a ser consultado
                        Produto produtoConsultado = gerenciador.BuscarProdutoPorCodigo(codigoConsulta); // Busca o produto na lista pelo código
                        if (produtoConsultado != null) // Se o produto foi encontrado
                        {
                            Console.WriteLine($"Produto encontrado: Código: {produtoConsultado.codigo}, Nome: {produtoConsultado.nome}, Preço: {produtoConsultado.preco:C}, Quantidade em Estoque: {produtoConsultado.quantidadeEmEstoque}"); // Exibe os detalhes do produto
                        }
                        else // Se o produto não foi encontrado
                        {
                            Console.WriteLine("Produto não encontrado."); // Exibe uma mensagem de erro
                        }
                        break;

                    case 4: // Caso o usuário escolha sair do programa
                        Console.WriteLine("Encerrando o programa."); // Exibe uma mensagem de saída
                        return; // Sai do método Main e encerra o programa

                    default: // Caso o usuário escolha uma opção inválida
                        Console.WriteLine("Opção inválida. Tente novamente."); // Exibe uma mensagem de erro
                        break;
                }
            }
        }
    }
}
