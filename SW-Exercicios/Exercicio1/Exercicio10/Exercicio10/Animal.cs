using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    public class Animal // Declaração da classe Animal.
    {
        private string _nome; // Declaração de uma variável privada para armazenar o nome do animal.
        private string _especie; // Declaração de uma variável privada para armazenar a espécie do animal.
        private int _idade; // Declaração de uma variável privada para armazenar a idade do animal.

        public Animal(string nome, string especie, int idade) // Construtor da classe Animal que recebe o nome, espécie e idade como parâmetros.
        {
            _nome = nome; // Inicializa a variável _nome com o valor do parâmetro nome.
            _especie = especie; // Inicializa a variável _especie com o valor do parâmetro especie.
            _idade = idade; // Inicializa a variável _idade com o valor do parâmetro idade.
        }

        public string Nome // Propriedade pública Nome que permite acessar e modificar o nome do animal.
        {
            get { return _nome; } // Retorna o valor armazenado na variável _nome.
            set { _nome = value; } // Define o valor da variável _nome com o valor passado como parâmetro.
        }

        public string Especie // Propriedade pública Especie que permite acessar e modificar a espécie do animal.
        {
            get { return _especie; } // Retorna o valor armazenado na variável _especie.
            set { _especie = value; } // Define o valor da variável _especie com o valor passado como parâmetro.
        }

        public int Idade // Propriedade pública Idade que permite acessar e modificar a idade do animal.
        {
            get { return _idade; } // Retorna o valor armazenado na variável _idade.
            set { _idade = value; } // Define o valor da variável _idade com o valor passado como parâmetro.
        }

        public void EmitirSom(string somDoAnimal) // Método público EmitirSom que exibe o som emitido pelo animal.
        {
            Console.WriteLine(somDoAnimal); // Exibe o som emitido pelo animal no console.
        }
    }
}
