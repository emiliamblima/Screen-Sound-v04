using Screen_Sound_v04.Modelos;
using System.Text.Json;
using Screen_Sound_v04.Filtros;

using (HttpClient client = new HttpClient()) 
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        LinqFilter.FiltrarPorTonalidade(musicas,"C#");
        ///LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas,"rock");
        // LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Paramore");
        //LinqFilter.FiltrarMusicasPorAno(musicas, "2002")





        //var musicasPreferidasDaEmilia = new MusicasPreferidas("Emilia");
        //musicasPreferidasDaEmilia.AdicionarMusicasFavoritas(musicas[10]);
        //musicasPreferidasDaEmilia.AdicionarMusicasFavoritas(musicas[15]);
        //musicasPreferidasDaEmilia.AdicionarMusicasFavoritas(musicas[20]);
        //musicasPreferidasDaEmilia.AdicionarMusicasFavoritas(musicas[5]);
        //musicasPreferidasDaEmilia.AdicionarMusicasFavoritas(musicas[255]);

        }
    catch(Exception ex)
    {
        Console.WriteLine($"Temos um problema:  {ex.Message}");
    }
    


}
