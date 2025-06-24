namespace Autotests.Models.APIModels.StudentsModels.StudentsRequestsModels;

public class CreateStudentRequestModel
{
    public string Name { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public int Age { get; set; }
    public int FacultetId { get; set; }
}
