using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    public class Tarefa // Definição da classe Tarefa
    {
        public string descricao; // Descrição da tarefa
        public DateTime dataVencimento; // Data de vencimento da tarefa

        // Construtor da classe Tarefa
        public Tarefa(string descricao, DateTime dataVencimento)
        {
            this.descricao = descricao; // Atribui a descrição passada como parâmetro à propriedade descricao
            this.dataVencimento = dataVencimento; // Atribui a data de vencimento passada como parâmetro à propriedade dataVencimento
        }

        // Método para verificar se a tarefa deve ser executada hoje
        public bool DeveSerExecutadaHoje()
        {
            return dataVencimento.Date == DateTime.Today; // Retorna verdadeiro se a data de vencimento da tarefa for igual à data atual
        }
    }

    public class GerenciadorDeTarefas // Definição da classe GerenciadorDeTarefas
    {
        private List<Tarefa> ListaDeTarefas; // Lista para armazenar as tarefas

        // Construtor da classe GerenciadorDeTarefas
        public GerenciadorDeTarefas()
        {
            ListaDeTarefas = new List<Tarefa>(); // Inicializa a lista de tarefas
        }

        // Método para adicionar uma nova tarefa à lista
        public void AdicionarTarefa(string descricao, DateTime dataVencimento)
        {
            Tarefa novaTarefa = new Tarefa(descricao, dataVencimento); // Cria uma nova instância da classe Tarefa
            ListaDeTarefas.Add(novaTarefa); // Adiciona a nova tarefa à lista de tarefas
        }

        // Método para remover uma tarefa da lista
        public void RemoverTarefa(string descricaoInformada)
        {
            Tarefa tarefaParaRemover = ListaDeTarefas.Find(t => t.descricao == descricaoInformada); // Busca a tarefa na lista pelo nome
            if (tarefaParaRemover != null) // Se a tarefa foi encontrada
            {
                ListaDeTarefas.Remove(tarefaParaRemover); // Remove a tarefa da lista de tarefas
            }
        }

        // Método para listar todas as tarefas
        public List<Tarefa> ListarTarefas()
        {
            return ListaDeTarefas; // Retorna a lista de tarefas
        }

        // Método para listar as tarefas que devem ser executadas hoje
        public List<Tarefa> TarefasParaExecutarHoje()
        {
            return ListaDeTarefas.FindAll(tarefas => tarefas.DeveSerExecutadaHoje()); // Retorna uma lista das tarefas cuja data de vencimento é hoje
        }
    }
}
