using System.Text.Json.Serialization;

namespace DotNetConsumingApis.models;

public class Musica
{
  [JsonPropertyName("song")]
  public string? Nome { get; set; }
  [JsonPropertyName("artist")]
  public string? Artista { get; set; }
  [JsonPropertyName("duration_ms")]
  public int? Duracao { get => field / 1000; set; }
  [JsonPropertyName("genre")]
  public string? Genero { get; set; }

  public void ExibirDetalhesMusica()
  {
    Console.WriteLine($"{Nome} - {Artista} - {Genero} - {Duracao}");
  }
}
