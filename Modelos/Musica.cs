using System.Globalization;
using System.Text.Json.Serialization;

namespace Screen_Sound_v04.Modelos;

internal class Musica
{

    private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };

    [JsonPropertyName("song")]
    public string? Nome { get; set; }

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    [JsonPropertyName("year")]
    public string? Ano { get; set; }

    [JsonPropertyName("key")]
    public int Key { get; set; }
    public String Tonalidade {
        get
        {

            return tonalidades[Key];


        }
    }   
public void ExibirDetalhesDaMusica() 
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Música:  {Nome}");
        Console.WriteLine($"Duração em segudos: {Duracao/1000}");
        Console.WriteLine($"Gênero musical:  {Genero}");
        Console.WriteLine($"Tonalidade: {Tonalidade}");

    }
}
