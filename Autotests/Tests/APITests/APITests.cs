using Autotests.Models.APIModels.StudentsModels;
using Newtonsoft.Json;

namespace Autotests.Tests.APITests;

public class APITests : BaseAPITests
{
    [Test]
    public async Task TestApiMethods()
    {
        var getResponse = await DI.RestAPIHelper.Get("http://109.172.115.139:5000/api/Students/GetStudents");
        
        var jsonObj = JsonConvert.DeserializeObject<GetStudentsResponseModel>(getResponse);

    }
}
