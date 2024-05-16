namespace Exercicio2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("***** Registro De Compras *****"); // Exibe um cabeçalho

            RegistroDeCompras registro = new RegistroDeCompras(); // Instancia um novo objeto RegistroDeCompras

            Console.WriteLine("Informe os dados das compras: "); // Solicita ao usuário que informe os dados das compras

            // Loop para permitir que o usuário adicione múltiplas compras
            while (true)
            {
                Console.Write("Data da compra (AAAA-MM-DD): ");
                if (DateTime.TryParse(Console.ReadLine(), out DateTime data)) // Tenta converter a entrada do usuário para DateTime
                {
                    Console.Write("Nome do produto: ");
                    string produto = Console.ReadLine(); // Obtém o nome do produto

                    Console.Write("Valor da compra: ");
                    if (double.TryParse(Console.ReadLine(), out double valor)) // Tenta converter a entrada do usuário para double
                    {
                        registro.AdicionarCompra(data, produto, valor); // Adiciona a compra à lista de compras
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido. Certifique-se de digitar um número válido."); // Exibe uma mensagem de erro se o valor for inválido
                    }
                }
                else
                {
                    Console.WriteLine("Data inválida. Certifique-se de digitar uma data no formato AAAA-MM-DD."); // Exibe uma mensagem de erro se a data for inválida
                }

                Console.Write("Deseja adicionar outra compra? (S/N): ");
                string resposta = Console.ReadLine(); // Obtém a resposta do usuário

                if (resposta.Equals("N", StringComparison.OrdinalIgnoreCase)) // Verifica se o usuário deseja parar de adicionar compras
                {
                    break; // Sai do loop
                }
            }

            registro.ListarCompras(); // Lista todas as compras registradas

            Console.ReadKey(); // Aguarda o usuário pressionar uma tecla antes de fechar o programa
        }
    }
}
