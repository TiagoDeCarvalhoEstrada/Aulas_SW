namespace Atividade2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoas p = new Pessoas();
            p.Nome = "Tiago";
            p.DataNasc = new DateTime(2007, 10, 14);
            p.Altura = 1.76f;

            p.ImprimirDados();

            int idade = p.CalcularIdade();

            Console.WriteLine("Idade: " + idade);

            Console.ReadKey();
        }
    }
}