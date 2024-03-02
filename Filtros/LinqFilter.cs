using Screen_Sound_v04.Modelos;
using System.Net.NetworkInformation;

namespace Screen_Sound_v04.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => 
        generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero) 
    {
        var artistasPorGeneroMusical = musicas.Where(musica => 
          musica.Genero!.Contains(genero)).Select(musica => 
          musica.Artista ).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas por gênero musical >>>{ genero}");
        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista) 
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals
            (nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);
        foreach(var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }

    }

    public static void FiltrarMusicasPorAno(List<Musica> musicas, string anoMusica) 
    {
        var musicaPorAno = musicas.Where(musica => musica.Ano.Equals(anoMusica)).ToList();
        Console.WriteLine($"Exibindo músicas do ano >>>{anoMusica}");
        foreach (var musica in musicaPorAno)
        {
            Console.WriteLine($"- {musica.Nome} - {musica.Artista} ");
        }


    }

    public static void FiltrarPorTonalidade(List<Musica> musicas,string tom) 
    {
        var musicaPorTonalidade = musicas.Where(musica => musica.Tonalidade.Equals(tom)).ToList();
        Console.WriteLine($"Exibindo tonalidade {tom}");
        foreach (var musica in musicaPorTonalidade) 
        { 
            Console.WriteLine($"{musica.Nome} - {musica.Tonalidade}");
        }
    }
}
