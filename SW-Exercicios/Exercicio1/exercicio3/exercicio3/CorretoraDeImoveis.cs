using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
    public class CorretoraDeImoveis
    {
        private List<Imovel> listaDeImoveis = new List<Imovel>(); // Lista para armazenar os imóveis

        // Definição da classe Imovel
        public class Imovel
        {
            public string endereco; // Endereço do imóvel
            public double preco; // Preço do imóvel
            public string tipo; // Tipo do imóvel

            // Construtor da classe Imovel
            public Imovel(string endereco, double preco, string tipo)
            {
                this.endereco = endereco; // Atribui o endereço passado como parâmetro à propriedade endereco
                this.preco = preco; // Atribui o preço passado como parâmetro à propriedade preco
                this.tipo = tipo; // Atribui o tipo passado como parâmetro à propriedade tipo
            }
        }

        // Método para inserir um novo imóvel na lista
        public void InserirImovel(string endereco, double preco, string tipo)
        {
            Imovel imovel = new Imovel(endereco, preco, tipo); // Cria uma nova instância da classe Imovel
            listaDeImoveis.Add(imovel); // Adiciona o novo imóvel à lista de imóveis
            Console.WriteLine("Imóvel inserido com sucesso!"); // Exibe uma mensagem de sucesso
        }

        // Método para alterar o preço de um imóvel
        public void AlterarPrecoDoImovel(string enderecoInformado, double novoPreco)
        {
            Imovel imovel = listaDeImoveis.Find(i => i.endereco == enderecoInformado); // Busca o imóvel pelo endereço

            if (imovel != null) // Verifica se o imóvel foi encontrado
            {
                imovel.preco = novoPreco; // Altera o preço do imóvel
                Console.WriteLine("Preço do imóvel alterado com sucesso!"); // Exibe uma mensagem de sucesso
            }
            else
            {
                Console.WriteLine("Imóvel não encontrado."); // Exibe uma mensagem de erro se o imóvel não foi encontrado
            }
        }

        // Método para listar todos os imóveis disponíveis
        public void ListarImoveis()
        {
            Console.WriteLine("Imóveis disponíveis:"); // Exibe um cabeçalho

            // Itera sobre cada imóvel na lista de imóveis
            foreach (Imovel imovel in listaDeImoveis)
            {
                // Exibe os detalhes do imóvel formatados
                Console.WriteLine($"Endereço: {imovel.endereco}, Tipo: {imovel.tipo}, Preço: R${imovel.preco.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}");
            }
        }

        // Método para calcular o valor médio dos imóveis
        public double CalcularValorMedio()
        {
            if (listaDeImoveis.Count == 0)
            {
                return 0; // Retorna 0 se não houver imóveis na lista
            }

            double somaPrecos = listaDeImoveis.Sum(imovel => imovel.preco); // Calcula a soma dos preços dos imóveis
            somaPrecos.ToString("F2", System.Globalization.CultureInfo.InvariantCulture); // Formata a soma para duas casas decimais
            return somaPrecos / listaDeImoveis.Count; // Retorna a média dos preços dos imóveis
        }
    }
}
