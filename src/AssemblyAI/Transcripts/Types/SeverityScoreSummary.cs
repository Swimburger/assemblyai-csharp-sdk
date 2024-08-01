using System.Text.Json.Serialization;

#nullable enable

namespace AssemblyAI.Transcripts;

public record SeverityScoreSummary
{
    [JsonPropertyName("low")]
    public required double Low { get; set; }

    [JsonPropertyName("medium")]
    public required double Medium { get; set; }

    [JsonPropertyName("high")]
    public required double High { get; set; }
}
