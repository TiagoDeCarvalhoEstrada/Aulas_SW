using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class RegistroDeCompras
    {
        private List<Compra> compras; // Lista para armazenar as compras

        // Definição da classe Compra
        public class Compra
        {
            public DateTime data; // Data da compra
            public string produto; // Nome do produto comprado
            public double valor; // Valor da compra

            // Construtor da classe Compra
            public Compra(DateTime data, string produto, double valor)
            {
                this.data = data; // Atribui a data passada como parâmetro à propriedade data
                this.produto = produto; // Atribui o nome do produto passado como parâmetro à propriedade produto
                this.valor = valor; // Atribui o valor passado como parâmetro à propriedade valor
            }
        }

        // Construtor da classe RegistroDeCompras
        public RegistroDeCompras()
        {
            compras = new List<Compra>(); // Inicializa a lista de compras
        }

        // Método para adicionar uma nova compra
        public void AdicionarCompra(DateTime data, string produto, double valor)
        {
            Compra novaCompra = new Compra(data, produto, valor); // Cria uma nova instância da classe Compra
            compras.Add(novaCompra); // Adiciona a nova compra à lista de compras
        }

        // Método para listar todas as compras
        public void ListarCompras()
        {
            Console.WriteLine("Lista de Compras: "); // Exibe um cabeçalho

            // Itera sobre cada compra na lista de compras
            foreach (Compra compra in compras)
            {
                // Exibe os detalhes da compra formatados
                Console.WriteLine($"Data: {compra.data}, Produto: {compra.produto}, Valor: {compra.valor.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}");
            }
        }
    }
}
