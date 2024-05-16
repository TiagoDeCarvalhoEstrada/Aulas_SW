namespace Exercicio10
{
    internal class Program // Declaração de uma classe interna chamada Program.
    {
        private static void Main(string[] args) // Método de entrada do programa.
        {
            Console.WriteLine("***** Animal *****"); // Exibe uma mensagem no console indicando o início da interação com o programa.

            Console.WriteLine("\nDigite as informações do Animal: "); // Solicita ao usuário que insira as informações do animal.
            Console.Write("Nome: "); // Solicita ao usuário que insira o nome do animal.
            string nomeDoAnimal = Console.ReadLine(); // Lê o nome do animal inserido pelo usuário e armazena na variável nomeDoAnimal.
            Console.Write("Espécie: "); // Solicita ao usuário que insira a espécie do animal.
            string especieDoAnimal = Console.ReadLine(); // Lê a espécie do animal inserida pelo usuário e armazena na variável especieDoAnimal.
            Console.Write("Idade: "); // Solicita ao usuário que insira a idade do animal.
            int idadeDoAnimal = int.Parse(Console.ReadLine()); // Lê a idade do animal inserida pelo usuário e converte para um inteiro, armazenando na variável idadeDoAnimal.
            Console.Write("Som: "); // Solicita ao usuário que insira o som emitido pelo animal.
            string somDoAnimal = Console.ReadLine(); // Lê o som emitido pelo animal inserido pelo usuário e armazena na variável somDoAnimal.

            Animal animal = new Animal(nomeDoAnimal, especieDoAnimal, idadeDoAnimal); // Cria uma instância da classe Animal com as informações fornecidas pelo usuário.

            Console.WriteLine("\n----- Resultado -----"); // Exibe uma separação indicando o resultado.
            Console.WriteLine($"Nome: {animal.Nome}"); // Exibe o nome do animal na tela.
            Console.WriteLine($"Espécie: {animal.Especie}"); // Exibe a espécie do animal na tela.
            Console.WriteLine($"Idade: {animal.Idade} anos"); // Exibe a idade do animal na tela.
            Console.Write($"O animal emite o som: ");
            animal.EmitirSom(somDoAnimal); // Chama o método EmitirSom da instância animal, passando o som emitido pelo animal como argumento.

            Console.ReadKey(); // Aguarda que o usuário pressione uma tecla antes de encerrar o programa.
        }
    }
}
