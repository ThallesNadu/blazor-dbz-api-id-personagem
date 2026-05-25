using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorDragonBallApi.Models
{
    public class Personagem
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Nome { get; set; }

        [JsonPropertyName("originPlanet")]
        public PlanetaOrigem Planeta { get; set; }

        [JsonPropertyName("transformations")]
        public List<Transformacao> Transformacoes { get; set; }
    }
}