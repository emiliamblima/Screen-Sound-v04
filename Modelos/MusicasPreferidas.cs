using System.Text.Json;
namespace Screen_Sound_v04.Modelos;


internal class MusicasPreferidas
{
    public string? Nome { get; set; }
    public List<Musica> ListaDeMusicasFavoritas { get; }

    public MusicasPreferidas(string nome) 
    { 
        Nome = nome;   
        ListaDeMusicasFavoritas = new List<Musica>();
    
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica );
    }

    public void ExibirMusicasFavoridas() 
    {
        Console.WriteLine($"Esssas são as músicas favoritas -> {Nome}");
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
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"O arquivo Json foi criado com sucesso!{Path.GetFullPath(nomeDoArquivo)}");
    }
}
