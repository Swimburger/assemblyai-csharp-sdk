using System.Text.Json.Serialization;

#nullable enable

namespace AssemblyAI.Transcripts;

public record TranscriptReadyNotification
{
    /// <summary>
    /// The ID of the transcript
    /// </summary>
    [JsonPropertyName("transcript_id")]
    public required string TranscriptId { get; set; }

    /// <summary>
    /// The status of the transcript. Either completed or error.
    /// </summary>
    [JsonPropertyName("status")]
    public required TranscriptReadyStatus Status { get; set; }
}
