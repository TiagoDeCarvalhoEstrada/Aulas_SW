namespace Exercicio9
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("******** Livro ********"); // Exibe uma mensagem no console indicando o início da interação com o programa.

            Console.WriteLine("Digite os dados do Livro: "); // Solicita ao usuário que insira os dados do livro.
            Console.Write("Título: "); // Solicita ao usuário que insira o título do livro.
            string tituloDoLivro = Console.ReadLine(); // Lê o título do livro inserido pelo usuário e armazena na variável tituloDoLivro.
            Console.Write("Autor: "); // Solicita ao usuário que insira o autor do livro.
            string nomeDoAutor = Console.ReadLine(); // Lê o nome do autor inserido pelo usuário e armazena na variável nomeDoAutor.

            Console.WriteLine("\n-------- Resultado --------"); // Exibe uma separação indicando o resultado.

            try // Inicia um bloco try-catch para tratar possíveis exceções que podem ocorrer durante a execução do código.
            {
                Livro livro = new Livro(tituloDoLivro, nomeDoAutor); // Cria uma instância da classe Livro com o título e autor fornecidos pelo usuário.
                Console.WriteLine($"Título: {livro.Titulo}"); // Exibe o título do livro na tela.
                Console.WriteLine($"Autor: {livro.Autor}"); // Exibe o autor do livro na tela.
            }
            catch (ArgumentException exception) // Captura uma exceção do tipo ArgumentException, que pode ser lançada se os dados fornecidos forem inválidos.
            {
                Console.WriteLine($"Erro: {exception.Message}"); // Exibe a mensagem de erro associada à exceção capturada.
            }

            Console.ReadKey(); // Aguarda que o usuário pressione uma tecla antes de encerrar o programa.
        }
    }
}
