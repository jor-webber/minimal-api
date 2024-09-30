using System.Text.Json.Serialization;

namespace SanteMinimalWebApi.Models
{
    public class Name
    {
        [JsonPropertyName("given")]
        public string[]? Given { get; set; }
        [JsonPropertyName("family")]
        public string[]? Family { get; set; }
    }
}
