using API_Sound.Modelos;

namespace API_Sound.Filtros;

internal class LinqFilter
{
    public static void FiltrarGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();

        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genero}");

        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasDoArtista(List<Musica> musicas, string artista)
    {
        var playlist = musicas.Where(musica => musica.Artista!.Equals(artista)).ToList();
        Console.WriteLine($"Exibindo músicas do artista >>> {artista}");

        foreach (var musica in playlist)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    public static void FiltrarMusicasPorTonalidadeDosustenido(List<Musica> musicas)
    {
        var playlist = musicas.Where(musica => musica.Tonalidade.Equals("C#")).ToList();
        Console.WriteLine($"Exibindo músicas pela tonalidade >>> C#");

        foreach (var musica in playlist)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }
}
