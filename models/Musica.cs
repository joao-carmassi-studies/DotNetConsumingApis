using System.Text.Json.Serialization;

namespace DotNetConsumingApis.models;

public class Musica
{
  [JsonPropertyName("song")]
  public string? Nome { get; private set; }
  [JsonPropertyName("artist")]
  public string? Artista { get; private set; }
  [JsonPropertyName("duration_ms")]
  public int? Duracao { get => field / 1000; private set; }
  [JsonPropertyName("genre")]
  public string? Genero { get; private set; }

  public void ExibirDetalhesMusica()
  {
    Console.WriteLine($"{Nome} - {Artista} - {Genero} - {Duracao}");
  }
}
