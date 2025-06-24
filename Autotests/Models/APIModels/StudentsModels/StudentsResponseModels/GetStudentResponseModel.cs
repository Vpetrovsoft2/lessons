using Newtonsoft.Json;

namespace Autotests.Models.APIModels.StudentsModels.StudentsResponseModels;

public class GetStudentsResponseModel
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("lastName")]
    public string? LastName { get; set; }

    [JsonProperty("age")]
    public int Age {  get; set; }

    [JsonProperty("facultetName")]
    public string? FacultetName { get; set; }
}
