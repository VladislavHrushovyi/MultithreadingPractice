namespace MultithreadingPractice.DoSomeProcess;

public interface ISomeProcess
{
    public void WriteToFile(string text, string threadId);
}