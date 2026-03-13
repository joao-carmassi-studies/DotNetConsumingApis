using DotNetConsumingApis.models;

namespace DotNetConsumingApis.Services;

public class LinqFilter
{
  public static void FiltraGenerosMusicas(List<Musica> musicas)
  {
    var generos = musicas
    .Select(generos => generos.Genero)
    .Distinct()
    .ToList();

    foreach (var genero in generos)
    {
      Console.WriteLine(genero);
    }
  }

  public static void FiltrarAtistasPorGenero(List<Musica> musica, string genero)
  {
    var artistasPorGenero = musica
    .Where(musica => musica.Genero!
      .Contains(genero)
    )
    .Select(musica => musica.Artista)
    .Distinct()
    .ToList();

    foreach (var artista in artistasPorGenero)
    {
      Console.WriteLine(artista);
    }
  }

  public static void FiltrarMusicasDeArtista(List<Musica> musicas, string nomeArtista)
  {
    var musicasFilstradas = musicas
    .Where(musicas => musicas.Artista!
    .Equals(nomeArtista))
    .ToList();

    foreach (var musica in musicasFilstradas)
    {
      Console.WriteLine(musica.Nome);
    }
  }
}
