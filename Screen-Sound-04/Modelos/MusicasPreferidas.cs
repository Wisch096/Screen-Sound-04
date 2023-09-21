using System.Text.Json;

namespace Screen_Sound_04.Modelos;

public class MusicasPreferidas
{
    public string? Nome { get; set; }
    public List<Musicas> ListaDeMusicasFavoritas { get; }

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musicas>();
    }

    public void AdicionarMusicasFavoritas(Musicas musicas)
    {
        ListaDeMusicasFavoritas.Add(musicas);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas são as músicas favoritas -> {Nome}");
        foreach (var musica in ListaDeMusicasFavoritas)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas
        });
        string NomeDoArquivo = $"musicas-favoritas-{Nome}.json";
        
        File.WriteAllText(NomeDoArquivo, json);
        Console.WriteLine($"Json foi criado com sucesso {Path.GetFullPath(NomeDoArquivo)}");
    }
}