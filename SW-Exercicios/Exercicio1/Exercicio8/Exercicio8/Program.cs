namespace Exercicio8
{
        internal class Program
        {
            static void Main(string[] args)
            {
                // Solicita ao usuário informações sobre o fabricante
                Console.WriteLine("Informe os dados do fabricante:");
                Console.Write("Nome: ");
                string nomeFabricante = Console.ReadLine();
                Console.Write("Endereço: ");
                string enderecoFabricante = Console.ReadLine();
                Console.Write("Cidade: ");
                string cidadeFabricante = Console.ReadLine();

                // Cria um objeto Fabricante com as informações fornecidas pelo usuário
                Fabricante fabricante = new Fabricante(nomeFabricante, enderecoFabricante, cidadeFabricante);

                // Solicita ao usuário informações sobre o produto
                Console.WriteLine("\nInforme os dados do produto:");
                Console.Write("Nome: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Preço: ");
                double precoProduto;
                while (!double.TryParse(Console.ReadLine(), out precoProduto) || precoProduto < 0)
                {
                    Console.WriteLine("Por favor, insira um valor válido para o preço (positivo).");
                    Console.Write("Preço: ");
                }

                // Cria um objeto Produto com as informações fornecidas pelo usuário
                Produto produto = new Produto(nomeProduto, fabricante, precoProduto);

                // Exibe as informações do produto
                Console.WriteLine("\nInformações do produto cadastrado:");
                Console.WriteLine($"Nome do produto: {produto.Nome}");
                Console.WriteLine($"Fabricante: {produto.Fabricante.Nome}, {produto.Fabricante.Endereco}, {produto.Fabricante.Cidade}");
                Console.WriteLine($"Preço: {produto.Preco:C}");
            }
        }
}
