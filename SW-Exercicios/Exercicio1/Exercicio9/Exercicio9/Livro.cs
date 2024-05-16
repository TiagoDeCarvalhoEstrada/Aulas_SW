using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    public class Livro
    {
        private string _titulo; // Declaração de uma variável privada para armazenar o título do livro.
        private string _autor; // Declaração de uma variável privada para armazenar o nome do autor do livro.

        public Livro(string titulo, string autor) // Declaração do construtor da classe Livro, que recebe o título e o autor do livro como parâmetros.
        {
            ValidarDados(titulo, autor); // Chamada do método ValidarDados para verificar se os dados fornecidos são válidos.
            _titulo = titulo; // Atribui o título fornecido ao campo privado _titulo.
            _autor = autor; // Atribui o nome do autor fornecido ao campo privado _autor.
        }

        public string Titulo // Propriedade pública Titulo para acessar e modificar o título do livro.
        {
            get { return _titulo; } // Método getter que retorna o valor do título.
            set { _titulo = value; } // Método setter que define o valor do título.
        }

        public string Autor // Propriedade pública Autor para acessar e modificar o nome do autor do livro.
        {
            get { return _autor; } // Método getter que retorna o valor do nome do autor.
            set { _autor = value; } // Método setter que define o valor do nome do autor.
        }

        private void ValidarDados(string titulo, string nome) // Método privado para validar os dados do título e do autor do livro.
        {
            if (string.IsNullOrWhiteSpace(titulo)) // Verifica se o título é nulo, vazio ou contém apenas espaços em branco.
            {
                throw new ArgumentException("O título do livro não pode ser vazio ou nulo!"); // Lança uma exceção se o título for inválido.
            }
            else if (string.IsNullOrWhiteSpace(nome)) // Verifica se o nome do autor é nulo, vazio ou contém apenas espaços em branco.
            {
                throw new ArgumentException("O nome do autor não pode ser vazio ou nulo!"); // Lança uma exceção se o nome do autor for inválido.
            }
        }
    }
}
