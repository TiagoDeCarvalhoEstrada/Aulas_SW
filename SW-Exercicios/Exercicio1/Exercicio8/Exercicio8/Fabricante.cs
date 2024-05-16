using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    public class Fabricante
    {
        // Propriedades da classe Fabricante
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }

        // Construtor da classe Fabricante
        public Fabricante(string nome, string endereco, string cidade)
        {
            Nome = nome;
            Endereco = endereco;
            Cidade = cidade;
        }
    }
}
