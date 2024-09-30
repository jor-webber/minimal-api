using System.Text.Json.Serialization;

namespace SanteMinimalWebApi.Models
{
    public class Address
    {
        [JsonPropertyName("line")]
        public string[]? Line { get; set; }
        [JsonPropertyName("state")]
        public string? State { get; set; }
    }
}
