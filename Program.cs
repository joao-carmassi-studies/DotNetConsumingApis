using System.Text.Json;
using DotNetConsumingApis.models;
using DotNetConsumingApis.Services;

using (var client = new HttpClient())
{
  try
  {
    string res = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    var musicas = JsonSerializer.Deserialize<List<Musica>>(res)!;

    // LinqOrder.ListaDeArtistasOrdenados(musicas);
    // LinqFilter.FiltraGenerosMusicas(musicas);
    // LinqFilter.FiltrarAtistasPorGenero(musicas, "rock");
    LinqFilter.FiltrarMusicasDeArtista(musicas, "U2");
  }
  catch (Exception ex)
  {
    Console.WriteLine($"Erro fetching Api data: {ex}");
  }
}

Console.ReadKey();