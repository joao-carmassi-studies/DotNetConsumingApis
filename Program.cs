using System.Text.Json;
using DotNetConsumingApis.Enums;
using DotNetConsumingApis.models;
using DotNetConsumingApis.Models;
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
    // LinqFilter.FiltrarMusicasDeArtista(musicas, "U2");

    var playList = new Playlist("Prazer Eu:", "Carmassi");
    playList.AddMuscias(musicas[1]);
    playList.AddMuscias(musicas[2]);
    playList.AddMuscias(musicas[3]);
    playList.AddMuscias(musicas[4]);
    playList.AddMuscias(musicas[5]);
    playList.ListaMusicas();
  }
  catch (Exception ex)
  {
    Console.WriteLine($"Erro fetching Api data: {ex}");
  }
}

Console.ReadKey();