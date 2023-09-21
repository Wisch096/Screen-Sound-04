using System.Text.Json.Serialization;

namespace Screen_Sound_04.Modelos
{
    public class Musicas
    {
        [JsonPropertyName("song")]
        public string? Nome { get; set; }

        [JsonPropertyName("artist")]
        public string? Artista { get; set; }

        [JsonPropertyName("duration_ms")]
        public int Duracao { get; set; }

        [JsonPropertyName("genre")]
        public string? Genero { get; set; }
        
        [JsonPropertyName("year")]
        public string? AnoString { get; set; }

        public int Ano
        {
            get
            {
                return int.Parse(AnoString!);
            }
        }

        public void ExibirDetalhesDaMusica()
        {
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Música: {Nome}");
            Console.WriteLine($"Duração: {Duracao / 1000}");
            Console.WriteLine($"Genêro musical: {Genero}");
        }
    }
}
