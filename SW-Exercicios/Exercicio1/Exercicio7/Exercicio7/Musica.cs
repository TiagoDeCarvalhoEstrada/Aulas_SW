using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    public class Musica
    {
        public string nome; // Propriedade para o nome da música
        public string autor; // Propriedade para o autor da música
        public string gravadora; // Propriedade para a gravadora da música

        // Construtor da classe Musica que recebe nome, autor e gravadora da música
        public Musica(string nome, string autor, string gravadora)
        {
            this.nome = nome; // Inicializa a propriedade nome com o valor fornecido
            this.autor = autor; // Inicializa a propriedade autor com o valor fornecido
            this.gravadora = gravadora; // Inicializa a propriedade gravadora com o valor fornecido
        }
    }
}
