namespace Exercicio12
{
    internal class Program // Declaração da classe Program (interna).
    {
        private static void Main(string[] args) // Método Main, ponto de entrada do programa.
        {
            Console.WriteLine("***** Agenda de Contatos *****"); // Exibe o cabeçalho do programa.

            Agenda agenda = new Agenda(); // Cria uma instância da classe Agenda.

            while (true) // Loop infinito para manter o programa em execução até que o usuário decida sair.
            {
                Console.WriteLine("\nMenu:"); // Exibe o menu de opções.
                Console.WriteLine("1. Adicionar Pessoa");
                Console.WriteLine("2. Remover Pessoa");
                Console.WriteLine("3. Buscar Pessoa");
                Console.WriteLine("4. Imprimir Agenda");
                Console.WriteLine("5. Sair");

                Console.Write("\nOpção: "); // Solicita ao usuário que escolha uma opção.
                int opcao = int.Parse(Console.ReadLine()); // Lê a opção escolhida pelo usuário.

                switch (opcao) // Estrutura switch para lidar com as opções escolhidas pelo usuário.
                {
                    case 1: // Opção para adicionar uma pessoa à agenda.
                        Console.WriteLine("\nDigite os dados da pessoa: ");
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Idade: ");
                        int idade = int.Parse(Console.ReadLine());
                        Console.Write("Altura: ");
                        float altura = float.Parse(Console.ReadLine());
                        agenda.ArmazenaPessoa(nome, idade, altura); // Chama o método ArmazenaPessoa da agenda para adicionar a pessoa.
                        break;

                    case 2: // Opção para remover uma pessoa da agenda.
                        Console.Write("Nome da pessoa a ser removida: ");
                        string nomeParaRemocao = Console.ReadLine();
                        agenda.RemovePessoa(nomeParaRemocao); // Chama o método RemovePessoa da agenda para remover a pessoa.
                        break;

                    case 3: // Opção para buscar uma pessoa na agenda.
                        Console.Write("Nome da pessoa que deseja buscar: ");
                        string nomeParaBusca = Console.ReadLine();
                        Pessoa pessoa = agenda.BuscaPessoa(nomeParaBusca); // Chama o método BuscaPessoa da agenda para encontrar a pessoa.

                        if (pessoa != null) // Verifica se a pessoa foi encontrada na agenda.
                        {
                            Console.WriteLine($"Pessoa encontrada - Nome: {pessoa.Nome}, Idade: {pessoa.Idade}, Altura: {pessoa.Altura}");
                        }
                        else
                        {
                            Console.WriteLine("Pessoa não encontrada na agenda!");
                        }
                        break;

                    case 4: // Opção para imprimir a agenda completa.
                        agenda.ImprimeAgenda(); // Chama o método ImprimeAgenda da agenda para imprimir a lista de contatos.
                        break;

                    case 5: // Opção para sair do programa.
                        Environment.Exit(0); // Encerra o programa.
                        break;

                    default: // Trata opções inválidas.
                        Console.WriteLine("Opção inválida, tente novamente!");
                        break;
                }
            }
        }
    }
}
