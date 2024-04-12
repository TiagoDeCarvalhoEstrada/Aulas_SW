using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    internal class Pessoas
    {
        private string nome;
        private DateTime dataNasc;
        private float altura;

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public DateTime DataNasc
        {
            get
            {
                return dataNasc;
            }
            set
            {
                dataNasc = value;
            }
        }

        public float Altura
        {
            get
            {
                return altura;
            }
            set
            {
                altura = value;
            }
        }

        public void ImprimirDados()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Data de Nascimento: " + dataNasc);
            Console.WriteLine("Altura: " + altura);
        }

        public int CalcularIdade()
        {
            return DateTime.Today.Year - dataNasc.Year;
        }
    }
}
