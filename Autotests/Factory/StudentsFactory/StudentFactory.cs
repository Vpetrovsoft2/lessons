using Autotests.Models.APIModels.StudentsModels.StudentsRequestsModels;

namespace Autotests.Factory.StudentsFactory;

public static class StudentFactory
{
    public static CreateStudentRequestModel Student
    {
        get
        {
            CreateStudentRequestModel createStudentRequestModel = new()
            {
                Name = DI.FormatHelper.GetRandomString(8),
                LastName = DI.FormatHelper.GetRandomString(8),
                Age = DI.FormatHelper.GetRandomNumberInt(0, 99),
                FacultetId = 1
            };

            return createStudentRequestModel;
        }
        set
        {
            Student = value;
        }
    }
}
