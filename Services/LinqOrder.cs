using DotNetConsumingApis.models;

namespace DotNetConsumingApis.Services;

public class LinqOrder
{
  public static void ListaDeArtistasOrdenados(List<Musica> musicas)
  {
    var artistasOrdenados = musicas
    .OrderBy(musica => musica.Artista)
    .Select(musica => musica.Artista)
    .Distinct()
    .ToList();

    foreach (var artista in artistasOrdenados)
    {
      Console.WriteLine(artista);
    }
  }
}
