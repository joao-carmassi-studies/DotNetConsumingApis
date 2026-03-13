using System.Text.Json;
using DotNetConsumingApis.models;

namespace DotNetConsumingApis.Models;

public class Playlist
{
  public string NomePlayList { get; private set; }
  public string NomeAutor { get; private set; }
  public List<Musica> Musicas { get; private set; }

  public Playlist(string nome, string autor)
  {
    NomePlayList = nome;
    NomeAutor = autor;
    Musicas = [];
  }

  public void AddMuscias(Musica music)
  {
    Musicas.Add(music);
  }

  public void ListaMusicas()
  {
    Console.WriteLine($"{NomePlayList}\n");
    foreach (var musica in Musicas)
    {
      Console.WriteLine($"{musica.Nome} - {musica.Artista}");
    }
  }

  public void GerarJson()
  {
    string json = JsonSerializer.Serialize(new
    {
      nome = NomePlayList,
      musicas = Musicas
    });

    var nomeArquivo = $"playlist-de-{NomeAutor}.json";
    File.WriteAllText(nomeArquivo, json);

    Console.WriteLine($"Arquivo gerado em {Path.GetFullPath(nomeArquivo)}");
  }
}
