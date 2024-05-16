using static Exercicio4.AgendaTelefonica;

namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Agenda Telefônica *****"); // Exibe um cabeçalho

            AgendaTelefonica agenda = new AgendaTelefonica(); // Instancia um novo objeto AgendaTelefonica

            // Loop para permitir que o usuário interaja com as opções do menu
            while (true)
            {
                Console.WriteLine("Opções:");
                Console.WriteLine("1. Adicionar contato");
                Console.WriteLine("2. Buscar contato");
                Console.WriteLine("3. Remover contato");
                Console.WriteLine("4. Sair");
                Console.Write("Escolha uma opção: ");
                int opcao = int.Parse(Console.ReadLine()); // Obtém a opção escolhida pelo usuário

                switch (opcao)
                {
                    case 1: // Caso o usuário escolha adicionar um contato
                        Console.Write("Nome do contato: ");
                        string nome = Console.ReadLine(); // Obtém o nome do contato
                        Console.Write("Telefone do contato: ");
                        string telefone = Console.ReadLine(); // Obtém o telefone do contato
                        Console.Write("Email do contato: ");
                        string email = Console.ReadLine(); // Obtém o email do contato
                        Contato novoContato = new Contato(nome, telefone, email); // Cria um novo objeto Contato
                        agenda.AdicionarContato(novoContato); // Adiciona o contato à agenda
                        break;
                    case 2: // Caso o usuário escolha buscar um contato
                        Console.Write("Nome do contato a ser buscado: ");
                        string nomeBusca = Console.ReadLine(); // Obtém o nome do contato a ser buscado
                        Contato contatoEncontrado = agenda.BuscarContato(nomeBusca); // Busca o contato na agenda
                        if (contatoEncontrado != null) // Se o contato foi encontrado
                        {
                            Console.WriteLine($"Contato encontrado: {contatoEncontrado.nome}, {contatoEncontrado.telefone}, {contatoEncontrado.email}"); // Exibe os detalhes do contato
                        }
                        else // Se o contato não foi encontrado
                        {
                            Console.WriteLine("Contato não encontrado.");
                        }
                        break;
                    case 3: // Caso o usuário escolha remover um contato
                        Console.Write("Nome do contato a ser removido: ");
                        string nomeRemocao = Console.ReadLine(); // Obtém o nome do contato a ser removido
                        Contato contatoRemocao = agenda.BuscarContato(nomeRemocao); // Busca o contato na agenda
                        if (contatoRemocao != null) // Se o contato foi encontrado
                        {
                            agenda.RemoverContato(contatoRemocao); // Remove o contato da agenda
                            Console.WriteLine("Contato removido com sucesso.");
                        }
                        else // Se o contato não foi encontrado
                        {
                            Console.WriteLine("Contato não encontrado.");
                        }
                        break;
                    case 4: // Caso o usuário escolha sair do programa
                        Environment.Exit(0); // Encerra o programa
                        break;
                    default: // Caso o usuário escolha uma opção inválida
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}
