using Newtonsoft.Json;

namespace Autotests.Models.APIModels.StudentsModels.StudentsResponseModels;

public class PutStudentResponseModel
{
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    [JsonProperty("lastName")]
    public string LastName { get; set; } = string.Empty;

    [JsonProperty("age")]
    public long Age { get; set; }

    [JsonProperty("facultet", NullValueHandling = NullValueHandling.Ignore)]
    public Facultet Facultet { get; set; } = new();
}

public class FacultetPut
{
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;

    [JsonProperty("lastName")]
    public string LastName { get; set; } = string.Empty;

    [JsonProperty("students")]
    public CreateStudentResponseModel[] Students { get; set; } = [];
}
