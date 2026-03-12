using System.Text.Json;
using DotNetConsumingApis.models;

using (var client = new HttpClient())
{
  try
  {
    string res = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    var muscias = JsonSerializer.Deserialize<List<Musica>>(res)!;

    Console.WriteLine(muscias.Count());
  }
  catch (Exception ex)
  {
    Console.WriteLine($"Erro fetching Api data: {ex}");
  }
}

Console.ReadKey();