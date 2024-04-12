namespace ExerAlbumDeFotos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Albumdefotos album = new Albumdefotos();

            Console.WriteLine("Digite a quantidade de páginas no seu álbum: ");
            album.NumdePag = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de fotos que deseja colocar: ");
            album.NumFotos = Convert.ToInt32(Console.ReadLine());

            album.Suporta();
            Console.WriteLine(album.Suporta());
        }
    }
}