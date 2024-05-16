namespace exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Corretora De Imóveis *****"); // Exibe um cabeçalho

            CorretoraDeImoveis corretora = new CorretoraDeImoveis(); // Instancia um novo objeto CorretoraDeImoveis

            // Loop para permitir que o usuário interaja com as opções do menu
            while (true)
            {
                int opcao;

                // Exibe o menu de opções
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1. Inserir imóvel");
                Console.WriteLine("2. Alterar preço do imóvel");
                Console.WriteLine("3. Listar imóveis");
                Console.WriteLine("4. Calcular valor médio dos imóveis");
                Console.WriteLine("5. Sair");
                Console.Write("\nOpção Escolhida: ");

                // Tenta converter a entrada do usuário para int
                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida. Tente novamente."); // Exibe uma mensagem de erro se a entrada for inválida
                    continue; // Volta ao início do loop
                }

                // Executa uma ação baseada na opção escolhida pelo usuário
                switch (opcao)
                {
                    case 1: // Caso o usuário escolha inserir um imóvel
                        Console.Write("Endereço do imóvel: ");
                        string endereco = Console.ReadLine();
                        Console.Write("Preço do imóvel: ");
                        double preco = double.Parse(Console.ReadLine());
                        Console.Write("Tipo do imóvel: ");
                        string tipo = Console.ReadLine();
                        corretora.InserirImovel(endereco, preco, tipo); // Chama o método InserirImovel da classe CorretoraDeImoveis
                        break;

                    case 2: // Caso o usuário escolha alterar o preço de um imóvel
                        Console.Write("Endereço do imóvel a ser alterado: ");
                        string enderecoAlterar = Console.ReadLine();
                        Console.Write("Novo preço: ");
                        double novoPreco = double.Parse(Console.ReadLine());
                        corretora.AlterarPrecoDoImovel(enderecoAlterar, novoPreco); // Chama o método AlterarPrecoDoImovel da classe CorretoraDeImoveis
                        break;

                    case 3: // Caso o usuário escolha listar os imóveis
                        corretora.ListarImoveis(); // Chama o método ListarImoveis da classe CorretoraDeImoveis
                        break;

                    case 4: // Caso o usuário escolha calcular o valor médio dos imóveis
                        double valorMedio = corretora.CalcularValorMedio(); // Chama o método CalcularValorMedio da classe CorretoraDeImoveis
                        Console.WriteLine($"O valor médio dos imóveis é: R${valorMedio}"); // Exibe o valor médio
                        break;

                    case 5: // Caso o usuário escolha sair do programa
                        Console.WriteLine("Saindo do programa.");
                        return; // Sai do método Main e encerra o programa

                    default: // Caso o usuário escolha uma opção inválida
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}
