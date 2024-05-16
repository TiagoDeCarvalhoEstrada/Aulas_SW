using static Exercicio5.GerenciadorDeTarefas;

namespace Exercicio5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("***** Gerenciador De Tarefa *****"); // Exibe um cabeçalho

            GerenciadorDeTarefas gerenciador = new GerenciadorDeTarefas(); // Instancia um novo objeto GerenciadorDeTarefas

            // Loop para permitir que o usuário interaja com as opções do menu
            while (true)
            {
                Console.WriteLine("\nOpções:");
                Console.WriteLine("1 - Adicionar Tarefa");
                Console.WriteLine("2 - Listar Tarefas para Hoje");
                Console.WriteLine("3 - Listar Todas as Tarefas");
                Console.WriteLine("4 - Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine(); // Obtém a opção escolhida pelo usuário

                Console.WriteLine();

                switch (opcao)
                {
                    case "1": // Caso o usuário escolha adicionar uma tarefa
                        Console.Write("Informe a descrição da tarefa: ");
                        string descricao = Console.ReadLine(); // Obtém a descrição da tarefa
                        Console.Write("Informe a data de vencimento (exemplo: 2023-10-26): ");
                        if (DateTime.TryParse(Console.ReadLine(), out DateTime dataVencimento)) // Tenta converter a entrada do usuário para DateTime
                        {
                            gerenciador.AdicionarTarefa(descricao, dataVencimento); // Adiciona a tarefa ao gerenciador de tarefas
                            Console.WriteLine("Tarefa adicionada com sucesso."); // Exibe uma mensagem de sucesso
                        }
                        else // Se a data não pôde ser convertida
                        {
                            Console.WriteLine("Data inválida. A tarefa não foi adicionada."); // Exibe uma mensagem de erro
                        }
                        break;
                    case "2": // Caso o usuário escolha listar tarefas para hoje
                        List<Tarefa> tarefasHoje = gerenciador.TarefasParaExecutarHoje(); // Obtém a lista de tarefas para hoje
                        Console.WriteLine("Tarefas para hoje:"); // Exibe um cabeçalho
                        foreach (Tarefa tarefa in tarefasHoje) // Itera sobre as tarefas para hoje
                        {
                            Console.WriteLine($"{tarefa.descricao} - {tarefa.dataVencimento}"); // Exibe a descrição e a data de vencimento da tarefa
                        }
                        break;
                    case "3": // Caso o usuário escolha listar todas as tarefas
                        List<Tarefa> todasAsTarefas = gerenciador.ListarTarefas(); // Obtém a lista de todas as tarefas
                        Console.WriteLine("Todas as tarefas:"); // Exibe um cabeçalho
                        foreach (Tarefa tarefa in todasAsTarefas) // Itera sobre todas as tarefas
                        {
                            Console.WriteLine($"{tarefa.descricao} - {tarefa.dataVencimento}"); // Exibe a descrição e a data de vencimento da tarefa
                        }
                        break;
                    case "4": // Caso o usuário escolha sair do programa
                        Console.WriteLine("Saindo do programa."); // Exibe uma mensagem de saída
                        return; // Sai do método Main e encerra o programa
                    default: // Caso o usuário escolha uma opção inválida
                        Console.WriteLine("Opção inválida. Tente novamente."); // Exibe uma mensagem de erro
                        break;
                }
            }
        }
    }
}
