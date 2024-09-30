using System.Text.Json.Serialization;

namespace SanteMinimalWebApi.Models
{
    public class Extension
    {
        [JsonPropertyName("url")]
        public string? Url { get; set; }
        [JsonPropertyName("valueString")]
        public string? ValueString { get; set; }
    }
}
