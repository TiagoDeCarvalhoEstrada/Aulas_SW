namespace Exercicio7
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("***** Bem-vindo(a) à sua playlist! *****"); // Exibe um cabeçalho

            // Solicita ao usuário o nome do dono da playlist
            Console.Write("Informe o nome do dono da playlist: ");
            string donoDaPlaylist = Console.ReadLine();

            Playlist minhaPlaylist = new Playlist(donoDaPlaylist); // Instancia um novo objeto Playlist com o nome do dono informado

            // Loop para permitir que o usuário interaja com as opções do menu
            while (true)
            {
                Console.WriteLine("\nOpções:");
                Console.WriteLine("1 - Adicionar música");
                Console.WriteLine("2 - Tocar música aleatória");
                Console.WriteLine("3 - Sair");

                Console.Write("Escolha uma opção: ");
                string escolha = Console.ReadLine(); // Obtém a opção escolhida pelo usuário

                if (escolha == "1") // Se o usuário escolher adicionar uma música
                {
                    // Solicita ao usuário informações sobre a nova música
                    Console.Write("Informe o nome da música: ");
                    string nome = Console.ReadLine();
                    Console.Write("Informe o nome do autor: ");
                    string autor = Console.ReadLine();
                    Console.Write("Informe o nome da gravadora: ");
                    string gravadora = Console.ReadLine();

                    // Cria uma nova música com as informações fornecidas e a adiciona à playlist
                    Musica novaMusica = new Musica(nome, autor, gravadora);
                    minhaPlaylist.AdicionarMusica(novaMusica);
                }
                else if (escolha == "2") // Se o usuário escolher tocar uma música aleatória
                {
                    minhaPlaylist.TocarMusicaAleatoria(); // Toca uma música aleatória da playlist
                }
                else if (escolha == "3") // Se o usuário escolher sair do programa
                {
                    break; // Sai do loop e encerra o programa
                }
                else // Se o usuário escolher uma opção inválida
                {
                    Console.WriteLine("Opção inválida. Tente novamente."); // Exibe uma mensagem de erro
                }
            }
        }
    }
}
