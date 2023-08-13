public class TestResultService : IResultService
{
    public void GetResult(int studentId)
    {
        Console.WriteLine(String.Format("I am NOT ResultingService, and this student has 55 marks"));
    }
}
