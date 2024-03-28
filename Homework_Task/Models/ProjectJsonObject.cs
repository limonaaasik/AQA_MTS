using System.Text.Json.Serialization;

namespace Homework_Task.Models;

public class ProjectJsonObject
{
    [JsonPropertyName("id")] public int Id { get; set; }
    [JsonPropertyName("announcement")] public string Announcement { get; set; }
    [JsonPropertyName("completed_on")] public int CompletedDateOn { get; set; }
    [JsonPropertyName("default_role_id")] public int DefaulRoleId { get; set; }
    [JsonPropertyName("default_role")] public string DefaultRole { get; set; }
    [JsonPropertyName("is_completed")] public bool IsCompleted { get; set; }
    [JsonPropertyName("name")] public string Name { get; set; }
    [JsonPropertyName("show_announcement")] public bool IsShowSnnouncement { get; set; }
    [JsonPropertyName("suite_mode")] public int SuiteMode { get; set; }
    [JsonPropertyName("url")] public string Url { get; set; }
    [JsonPropertyName("users")] public object Users { get; set; }
    [JsonPropertyName("groups")] public Array Groups { get; set; }
}