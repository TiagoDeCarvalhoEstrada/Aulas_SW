using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    public class Pessoa // Declaração da classe Pessoa.
    {
        private string _nome; // Declaração da variável privada _nome.
        private int _idade; // Declaração da variável privada _idade.
        private float _altura; // Declaração da variável privada _altura.

        public Pessoa(string nome, int idade, float altura) // Construtor da classe Pessoa.
        {
            _nome = nome; // Inicialização da variável _nome com o valor passado como parâmetro.
            _idade = idade; // Inicialização da variável _idade com o valor passado como parâmetro.
            _altura = altura; // Inicialização da variável _altura com o valor passado como parâmetro.
        }

        public string Nome // Propriedade Nome da classe Pessoa.
        {
            get { return _nome; } // Getter da propriedade Nome.
            set { _nome = value; } // Setter da propriedade Nome.
        }

        public int Idade // Propriedade Idade da classe Pessoa.
        {
            get { return _idade; } // Getter da propriedade Idade.
            set { _idade = value; } // Setter da propriedade Idade.
        }

        public float Altura // Propriedade Altura da classe Pessoa.
        {
            get { return _altura; } // Getter da propriedade Altura.
            set { _altura = value; } // Setter da propriedade Altura.
        }
    }

    public class Agenda // Declaração da classe Agenda.
    {
        private List<Pessoa> _listaDePessoas; // Declaração da lista privada _listaDePessoas que armazena objetos do tipo Pessoa.

        public Agenda() // Construtor da classe Agenda.
        {
            _listaDePessoas = new List<Pessoa>(); // Inicialização da lista _listaDePessoas.
        }

        public void ArmazenaPessoa(string nome, int idade, float altura) // Método para armazenar uma pessoa na agenda.
        {
            Pessoa pessoa = new Pessoa(nome, idade, altura); // Cria um novo objeto Pessoa com os dados fornecidos.
            _listaDePessoas.Add(pessoa); // Adiciona a pessoa à lista de pessoas.
        }

        public void RemovePessoa(string nome) // Método para remover uma pessoa da agenda.
        {
            Pessoa pessoa = BuscaPessoa(nome); // Busca a pessoa na lista.

            if (pessoa != null) // Verifica se a pessoa foi encontrada.
            {
                _listaDePessoas.Remove(pessoa); // Remove a pessoa da lista.
            }
            else // Se a pessoa não foi encontrada.
            {
                Console.WriteLine("Pessoa não encontrada na agenda."); // Exibe uma mensagem de erro.
            }
        }

        public Pessoa BuscaPessoa(string nome) // Método para buscar uma pessoa na agenda.
        {
            return _listaDePessoas.Find(p => p.Nome == nome); // Retorna a pessoa cujo nome corresponde ao fornecido.
        }

        public void ImprimeAgenda() // Método para imprimir a lista de pessoas na agenda.
        {
            Console.WriteLine("Agenda:"); // Exibe o cabeçalho da agenda.

            foreach (var pessoa in _listaDePessoas) // Itera sobre cada pessoa na lista.
            {
                Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}, Altura: {pessoa.Altura}"); // Exibe os detalhes da pessoa.
            }
        }
    }
}
