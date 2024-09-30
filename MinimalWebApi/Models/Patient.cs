using System.Text.Json.Serialization;

namespace SanteMinimalWebApi.Models
{
    public class Patient
    {
        [JsonPropertyName("resourceType")]
        public string? ResourceType { get; set; }
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        [JsonPropertyName("active")]
        public bool? Active { get; set; }
        [JsonPropertyName("name")]
        public Name[]? Name { get; set; }
        [JsonPropertyName("gender")]
        public string? Gender { get; set; }
        [JsonPropertyName("birthDate")]
        public string? BirthDate { get; set; }
        [JsonPropertyName("address")]
        public Address[]? Address { get; set; }
        [JsonPropertyName("extension")]
        public Extension[]? Extension { get; set; }
    }

}
