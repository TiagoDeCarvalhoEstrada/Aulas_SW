using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
        public class AgendaTelefonica // Definição da classe AgendaTelefonica
        {
            public class Contato // Definição da classe Contato
            {
                public string nome; // Nome do contato
                public string telefone; // Número de telefone do contato
                public string email; // Endereço de email do contato

                // Construtor da classe Contato
                public Contato(string nome, string telefone, string email)
                {
                    this.nome = nome; // Atribui o nome passado como parâmetro à propriedade nome
                    this.telefone = telefone; // Atribui o telefone passado como parâmetro à propriedade telefone
                    this.email = email; // Atribui o email passado como parâmetro à propriedade email
                }
            }

            private List<Contato> listaDeContatos; // Lista para armazenar os contatos

            // Construtor da classe AgendaTelefonica
            public AgendaTelefonica()
            {
                listaDeContatos = new List<Contato>(); // Inicializa a lista de contatos
            }

            // Método para adicionar um novo contato à lista
            public void AdicionarContato(Contato contatoInformado)
            {
                listaDeContatos.Add(contatoInformado); // Adiciona o contato à lista de contatos
            }

            // Método para remover um contato da lista
            public void RemoverContato(Contato contatoInformado)
            {
                listaDeContatos.Remove(contatoInformado); // Remove o contato da lista de contatos
            }

            // Método para buscar um contato pelo nome
            public Contato BuscarContato(string nomeInformado)
            {
                return listaDeContatos.Find(c => c.nome == nomeInformado); // Retorna o contato encontrado na lista pelo nome
            }
        }
    }

