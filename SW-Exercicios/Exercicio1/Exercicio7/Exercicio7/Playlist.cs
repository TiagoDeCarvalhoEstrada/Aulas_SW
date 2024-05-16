using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    public class Playlist // Definição da classe Playlist
    {
        private List<Musica> listaDeMusicas = new List<Musica>(); // Lista de músicas da playlist
        public string dono; // Propriedade para armazenar o dono da playlist

        public Playlist(string dono) // Construtor da classe Playlist
        {
            this.dono = dono; // Inicializa o dono da playlist com o valor fornecido
        }

        public void AdicionarMusica(Musica musica) // Método para adicionar uma música à playlist
        {
            listaDeMusicas.Add(musica); // Adiciona a música à lista de músicas da playlist
        }

        public void TocarMusicaAleatoria() // Método para tocar uma música aleatória da playlist
        {
            if (listaDeMusicas.Any()) // Verifica se há músicas na playlist
            {
                Random random = new Random(); // Cria uma nova instância da classe Random
                int indiceAleatorio = random.Next(listaDeMusicas.Count); // Gera um índice aleatório dentro do intervalo de índices da lista de músicas
                Musica musicaTocada = listaDeMusicas[indiceAleatorio]; // Seleciona a música com base no índice aleatório gerado
                Console.WriteLine($"Tocando a música: {musicaTocada.nome} - {musicaTocada.autor}"); // Exibe informações sobre a música tocada
            }
            else
            {
                Console.WriteLine("A playlist está vazia. Adicione músicas antes de tocar."); // Exibe uma mensagem se a playlist estiver vazia
            }
        }
    }
}
