namespace Autotests.Models.APIModels.StudentsModels;

public class GetStudentsResponseModel
{
    public List<GetStudentResponseModel> ListStudents { get; set; } = [];
}

public class GetStudentResponseModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public int Age {  get; set; }
    public string FacultetName { get; set; } = string.Empty;
}
