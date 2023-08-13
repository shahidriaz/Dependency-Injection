public class StudentService
{
    private readonly IResultService _resultService;
    public StudentService(IResultService resultService)
    {
        // The following line is creating the object of the Result Service, It is tight coupling
        this._resultService = resultService;
    }
    public void GetStudentResult()
    {
        _resultService.GetResult(10);
    }
}