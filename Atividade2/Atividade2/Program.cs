namespace Atividade2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PESSOAS!");
            static void Main(string[] args)
            {
                Pessoa p = new Pessoa();
                p.nome = "Joel";
                p.dataNascimento = new DateTime(1993, 6, 28);
                p.altura = 1.76f;

                p.ImprimirDados();

                int idade = p.CalcularIdade();

                Console.WriteLine("Idade: " + idade);

                Console.ReadKey();
            }

        }
    }
}