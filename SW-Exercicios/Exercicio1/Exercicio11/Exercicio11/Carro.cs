using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11
{
    public class Carro // Declaração da classe Carro.
    {
        private string _modelo; // Declaração de uma variável privada para armazenar o modelo do carro.
        private int _ano; // Declaração de uma variável privada para armazenar o ano do carro.
        private int _velocidade; // Declaração de uma variável privada para armazenar a velocidade do carro.

        public Carro(string modelo, int ano) // Construtor da classe Carro que recebe o modelo e o ano como parâmetros.
        {
            _modelo = modelo; // Inicializa a variável _modelo com o valor do parâmetro modelo.
            _ano = ano; // Inicializa a variável _ano com o valor do parâmetro ano.
            _velocidade = 0; // Inicializa a variável _velocidade com zero.
        }

        public string Modelo // Propriedade pública Modelo que permite acessar e modificar o modelo do carro.
        {
            get { return _modelo; } // Retorna o valor armazenado na variável _modelo.
            set { _modelo = value; } // Define o valor da variável _modelo com o valor passado como parâmetro.
        }

        public int Ano // Propriedade pública Ano que permite acessar e modificar o ano do carro.
        {
            get { return _ano; } // Retorna o valor armazenado na variável _ano.
            set { _ano = value; } // Define o valor da variável _ano com o valor passado como parâmetro.
        }

        public int Velocidade // Propriedade pública Velocidade que permite acessar a velocidade do carro (somente leitura).
        {
            get { return _velocidade; } // Retorna o valor armazenado na variável _velocidade.
        }

        public void Acelerar() // Método público Acelerar que aumenta a velocidade do carro em 10 unidades.
        {
            _velocidade += 10; // Incrementa a velocidade em 10 unidades.
        }

        public void Frear() // Método público Frear que diminui a velocidade do carro em 10 unidades, com mínimo de 0.
        {
            if (_velocidade >= 10) // Verifica se a velocidade é maior ou igual a 10.
            {
                _velocidade -= 10; // Diminui a velocidade em 10 unidades.
            }
            else // Se a velocidade for menor que 10.
            {
                _velocidade = 0; // Define a velocidade como zero.
            }
        }
    }
}
