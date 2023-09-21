using Screen_Sound_04.Modelos;

namespace Screen_Sound_04.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musicas> musicas)
    {
        var todosOsGenerosMusicais = musicas
            .Select(generos => generos.Genero)
            .Distinct()
            .ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musicas> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica =>
            musica.Genero.Contains(genero))
            .Select(musica => musica.Artista)
            .Distinct()
            .ToList();
        Console.WriteLine($"Exibindo os artistas por genêro musical >>> {genero}");

        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtistas(List<Musicas> musicas, string nomeDoArtista)
    {
        var musicaDoArtista = musicas
            .Where(musica => musica.Artista.Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);
        foreach (var musica in musicaDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    public static void FiltrarMusicasPeloAno(List<Musicas> musicas, int ano)
    {
        var musicaDoAno = musicas.Where(musica => musica.Ano == ano)
            .OrderBy(musicas => musicas.Nome)
            .Select(musicas => musicas.Nome)
            .Distinct()
            .ToList();
        
        Console.WriteLine($"Músicas de {ano}");
        foreach (var musica in musicaDoAno)
        {
            Console.WriteLine($"- {musica}");
        }
    }
}
