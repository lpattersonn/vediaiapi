using vediaiapi.Models;

namespace vediaiapi.Services;

public static class IntervieweeService
{
    static List<IntervieweeAccountModel> Interviewees { get; }
    static int nextId = 3;
    static IntervieweeService()
    {
        Interviewees = new List<IntervieweeAccountModel>
        {
            new IntervieweeAccountModel { Id = 1, FirstName = "Leshan", LastName = "Patterson", Email = "Leshan0627@gmail.com", Password = "1234", Bio = ""},
            new IntervieweeAccountModel { Id = 2, FirstName = "A", LastName = "I", Email = "leshan@leshanpatterson.com", Password = "1234", Bio = ""}
        };
    }

    public static List<IntervieweeAccountModel> GetAll() => Interviewees;
}