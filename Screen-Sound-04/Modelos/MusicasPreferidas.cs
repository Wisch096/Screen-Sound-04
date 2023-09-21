namespace Screen_Sound_04.Modelos;

public class MusicasPreferidas
{
    public string? Nome { get; set; }
    public List<Musicas> ListaDeMusicasFavoritas { get; }

    MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musicas>();
    }

    public void AdicionarMusicasFavoritas(Musicas musicas)
    {
        ListaDeMusicasFavoritas.Add(musicas);
    }
}