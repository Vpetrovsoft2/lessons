using Autotests.Factory.StudentsFactory;
using Autotests.Models.APIModels.StudentsModels.StudentsRequestsModels;
using Autotests.Models.APIModels.StudentsModels.StudentsResponseModels;

namespace Autotests.Tests.APITests;

public class ApiPutTests : BaseAPITests
{
    [Test]
    public void ApiPutChangeNameTest()
    {
        int id =
            DI.AllureReportHelper.RunStep("Выбираем случайного студента", () => 
            { 
                var studentsList = DI.APIHelper.GetStudents();
                int rndIndex = DI.FormatHelper.GetRandomNumberInt(0, studentsList.Count);
                return studentsList[rndIndex].Id;
            });

        CreateStudentRequestModel newStudent = StudentFactory.Student;

        PutStudentResponseModel putResponse = DI.APIHelper.PutStudent(id, newStudent);

        GetStudentsResponseModel getStudent = DI.APIHelper.GetStudentById(id);

        DI.AllureReportHelper.RunStep("Проверяем полученного студента", () => 
        {
            if (getStudent.Name == newStudent.Name)
                DI.AllureReportHelper.MessageInNewStep($"В ответе GET {nameof(getStudent.Name)}: {getStudent.Name} равен ожидаемому: {newStudent.Name}");
            else
                DI.AllureReportHelper.ErrorMessageInNewStep($"В ответе GET {nameof(getStudent.Name)}: {getStudent.Name} не равен ожидаемому: {newStudent.Name}");

            if (getStudent.LastName == newStudent.LastName)
                DI.AllureReportHelper.MessageInNewStep($"В ответе GET {nameof(getStudent.LastName)}: {getStudent.LastName} равен ожидаемому: {newStudent.LastName}");
            else
                DI.AllureReportHelper.ErrorMessageInNewStep($"В ответе GET {nameof(getStudent.LastName)}: {getStudent.LastName} не равен ожидаемому: {newStudent.LastName}");

            if (getStudent.Age == newStudent.Age)
                DI.AllureReportHelper.MessageInNewStep($"В ответе GET {nameof(getStudent.Age)}: {getStudent.Age} равен ожидаемому: {newStudent.Age}");
            else
                DI.AllureReportHelper.ErrorMessageInNewStep($"В ответе GET {nameof(getStudent.Age)}: {getStudent.Age} не равен ожидаемому: {newStudent.Age}");
        });
    }


}
