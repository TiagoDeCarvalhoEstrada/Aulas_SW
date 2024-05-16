using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    public class Produto
    {
        // Propriedades da classe Produto
        public string Nome { get; set; }
        public Fabricante Fabricante { get; set; }
        private double preco;

        // Propriedade para o preço com validação de valor positivo
        public double Preco
        {
            get { return preco; }
            set
            {
                if (value >= 0)
                {
                    preco = value;
                }
                else
                {
                    throw new ArgumentException("O preço deve ser um valor positivo.");
                }
            }
        }

        // Construtor da classe Produto
        public Produto(string nome, Fabricante fabricante, double preco)
        {
            // Verifica se o nome do produto não é vazio
            if (!string.IsNullOrEmpty(nome))
            {
                Nome = nome;
            }
            else
            {
                throw new ArgumentException("O nome do produto não pode ser vazio.");
            }

            Fabricante = fabricante;
            Preco = preco; // Utiliza a propriedade para garantir a validação do preço
        }
    }
}
