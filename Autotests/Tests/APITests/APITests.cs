using Autotests.Models.APIModels.StudentsModels.StudentsRequestsModels;
using Autotests.Models.APIModels.StudentsModels.StudentsResponseModels;
using Newtonsoft.Json;
using System.Text;

namespace Autotests.Tests.APITests;

public class APITests : BaseAPITests
{
    [Test]
    public async Task TestApiMethods()
    {
        CreateStudentRequestModel createStundentRequestModel = new()
        {
            Name = "Валерий",
            LastName = "Сюткин",
            Age = 33,
            FacultetId = 1
        };

        string postJson = JsonConvert.SerializeObject(createStundentRequestModel);

        var requestBody = new StringContent(postJson, encoding: Encoding.UTF8, "application/json");

        var postResponse = await DI.RestAPIHelper.Post("http://109.172.115.139:5000/api/Students/CreateStudent", requestBody);

        var postResponseModel = JsonConvert.DeserializeObject<CreateStudentResponseModel>(postResponse);





        var getResponse = await DI.RestAPIHelper.Get("http://109.172.115.139:5000/api/Students/GetStudents");
        
        var jsonObj = JsonConvert.DeserializeObject<List<GetStudentsResponseModel>>(getResponse);

    }
}
