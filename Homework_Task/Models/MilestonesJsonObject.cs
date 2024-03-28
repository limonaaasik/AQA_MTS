using System.Text.Json.Serialization;

namespace Homework_Task.Models;

public class MilestonesJsonObject
{
    [JsonPropertyName("completed_on")] public int DateCompletedOn { get; set; }
    [JsonPropertyName("description")] public string Description { get; set; }
    [JsonPropertyName("due_on")] public int DueOn { get; set; }
    [JsonPropertyName("id")] public int Id { get; set; }
    [JsonPropertyName("is_completed")] public bool IsCompleted { get; set; }
    [JsonPropertyName("name")] public string Name { get; set; }
    [JsonPropertyName("project_id")] public int ProjectId { get; set; }
    [JsonPropertyName("refs")] public string Refs { get; set; }
    [JsonPropertyName("url")] public string Url { get; set; }
}