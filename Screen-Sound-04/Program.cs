using Screen_Sound_04.Filtros;
using Screen_Sound_04.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/" +
            "api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musicas>>(resposta)!;
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        // LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        // LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        // LinqFilter.FiltrarMusicasDeUmArtistas(musicas, "Michel Teló");
        LinqFilter.FiltrarMusicasPeloAno(musicas, 2000);
    } catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
    
}
