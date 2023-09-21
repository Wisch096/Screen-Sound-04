using Screen_Sound_04.Modelos;
using System.Linq;


namespace Screen_Sound_04.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musicas> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musica => musica.Artista)
            .Select(musica => musica.Artista).Distinct().ToList();
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}
