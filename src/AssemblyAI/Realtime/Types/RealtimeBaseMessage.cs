using System.Text.Json.Serialization;

#nullable enable

namespace AssemblyAI.Realtime;

public record RealtimeBaseMessage
{
    /// <summary>
    /// Describes the type of the message
    /// </summary>
    [JsonPropertyName("message_type")]
    public required MessageType MessageType { get; set; }
}
