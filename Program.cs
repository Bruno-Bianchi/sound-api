using API_Sound.Modelos;
using System.Text.Json;
using API_Sound.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
            
        LinqFilter.FiltrarMusicasPorTonalidadeDosustenido(musicas);
        //LinqFilter.FiltrarGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        //LinqFilter.FiltrarMusicasDoArtista(musicas, "Post Malone");

        //var musicaPreferidasBruno = new MusicasPreferidas("Bruno");
        //musicaPreferidasBruno.AdicionarMusicasFavoritas(musicas[1]);
        //musicaPreferidasBruno.AdicionarMusicasFavoritas(musicas[2]);
        //musicaPreferidasBruno.AdicionarMusicasFavoritas(musicas[3]);
        //musicaPreferidasBruno.AdicionarMusicasFavoritas(musicas[4]);
        //musicaPreferidasBruno.AdicionarMusicasFavoritas(musicas[5]);

        //musicaPreferidasBruno.ExibirMusicasFavoritas();
        //musicaPreferidasBruno.GerarArquivoJson();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}