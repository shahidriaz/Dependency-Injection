public class ResultService : IResultService
{
    public void GetResult(int studentId)
    {
        Random marks = new Random();
        int result = marks.Next(50,100);
        Console.WriteLine(string.Format("Student haveing Id: {0} obtained total marks {1} out of 100", studentId,result ));
    }
}