using DotNetConsumingApis.models;

namespace DotNetConsumingApis.Models;

public class Playlist
{
  public string Nome { get; private set; }
  public List<Musica> Musicas { get; private set; }

  public Playlist(string nome)
  {
    Nome = nome;
    Musicas = [];
  }

  public void AddMuscias(Musica music)
  {
    Musicas.Add(music);
  }

  public void ListaMusicas()
  {
    Console.WriteLine($"{Nome}\n");
    foreach (var musica in Musicas)
    {
      Console.WriteLine($"{musica.Nome} - {musica.Artista}");
    }
  }
}
