using Autotests.Models.APIModels.StudentsModels.StudentsRequestsModels;
using Autotests.Models.APIModels.StudentsModels.StudentsResponseModels;
using Newtonsoft.Json;
using System.Text;

namespace Autotests.Helpers;

public class APIHelper
{
    private readonly string _apiURL = "http://109.172.115.139:5000/api/";

    public List<GetStudentsResponseModel> GetStudents()
    {
        List<GetStudentsResponseModel> jsonObj = new();
        DI.AllureReportHelper.RunStep("Получение всех студентов", () =>
        {
            var result = DI.RestAPIHelper.Get($"{_apiURL}Students/GetStudents").Result;
            jsonObj = JsonConvert.DeserializeObject<List<GetStudentsResponseModel>>(result)!;
        });

        return jsonObj;
    }

    public CreateStudentResponseModel CreateStudent(CreateStudentRequestModel student)
    {
        var postResponseModel = new CreateStudentResponseModel();
        DI.AllureReportHelper.RunStep($"Добавление студента {student.LastName} {student.Name}", () =>
        {
            var postJSON = JsonConvert.SerializeObject(student);
            var requestBody = new StringContent(postJSON, encoding: Encoding.UTF8, "application/json");
            var postResponse = DI.RestAPIHelper.Post($"{_apiURL}Students/CreateStudent", requestBody).Result;
            postResponseModel = JsonConvert.DeserializeObject<CreateStudentResponseModel>(postResponse);
        });
        return postResponseModel;
    }

    public GetStudentsResponseModel GetStudentById(int id)
    {
        GetStudentsResponseModel getStudentResponseModel = new();
        DI.AllureReportHelper.RunStep($"Получение студента по ID {id}", () =>
        {
            var result = DI.RestAPIHelper.Get($"{_apiURL}Students/GetStudent/{id}").Result;
            getStudentResponseModel = JsonConvert.DeserializeObject<GetStudentsResponseModel>(result)!;
        });
        return getStudentResponseModel;
    }

    public bool DeleteStudent(int id)
    {
        bool isDeleted = false;
        DI.AllureReportHelper.RunStep($"Удаление студента по ID {id}", () =>
        {
            isDeleted = DI.RestAPIHelper.Delete($"{_apiURL}Students/DeleteStudents/{id}").IsCompletedSuccessfully;
        });
        return isDeleted;
    }

    public PutStudentResponseModel PutStudent(int id, CreateStudentRequestModel updateData)
    {
        PutStudentResponseModel putStudentResponseModel = new();

        DI.AllureReportHelper.RunStep($"Изменяем данные студента: {id}", () => 
        {
            var postJSON = JsonConvert.SerializeObject(updateData);
            var requestBody = new StringContent(postJSON, encoding: Encoding.UTF8, "application/json");
            var putResponse = DI.RestAPIHelper.Put($"{_apiURL}Students/UpdateStudent/{id}", requestBody).Result;
            putStudentResponseModel = JsonConvert.DeserializeObject<PutStudentResponseModel>(putResponse)!;
        });

        return putStudentResponseModel;
    }
}