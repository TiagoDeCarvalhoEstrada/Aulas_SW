namespace Exercicio11
{
    internal class Program // Declaração da classe Program (interna).
    {
        private static void Main(string[] args) // Método Main, ponto de entrada do programa.
        {
            Console.WriteLine("***** Meu Carro *****");

            Console.WriteLine("\nDigite as informações do seu carro:"); // Solicita ao usuário que digite informações sobre o carro.
            Console.Write("Modelo: ");
            string modeloDoCarro = Console.ReadLine(); // Lê o modelo do carro digitado pelo usuário.
            Console.Write("Ano: ");
            int anoDeFabricacao = int.Parse(Console.ReadLine()); // Lê o ano de fabricação do carro digitado pelo usuário.

            Carro carro = new Carro(modeloDoCarro, anoDeFabricacao); // Cria uma nova instância da classe Carro com as informações fornecidas.

            Console.WriteLine("\n---------------- Resultado ----------------"); // Exibe uma linha de separação.
            Console.WriteLine($"Modelo: {carro.Modelo}, Ano: {carro.Ano}, Velocidade: {carro.Velocidade}"); // Exibe as informações do carro recém-criado.

            carro.Acelerar(); // Chama o método Acelerar do objeto carro.
            Console.WriteLine($"Acelerando... Velocidade: {carro.Velocidade}"); // Exibe a nova velocidade do carro.

            carro.Acelerar(); // Chama o método Acelerar novamente.
            Console.WriteLine($"Acelerando mais uma vez... Velocidade: {carro.Velocidade}"); // Exibe a nova velocidade do carro após a segunda aceleração.

            carro.Frear(); // Chama o método Frear do objeto carro.
            Console.WriteLine($"Freando uma vez... Velocidade: {carro.Velocidade}"); // Exibe a nova velocidade do carro após frear uma vez.

            carro.Frear(); // Chama o método Frear novamente.
            Console.WriteLine($"Freando... Velocidade: {carro.Velocidade}"); // Exibe a nova velocidade do carro após frear novamente.

            Console.ReadKey(); // Aguarda o pressionamento de uma tecla antes de fechar o programa.
        }
    }
}
