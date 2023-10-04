namespace MultithreadingPractice.Utils;

public class WriteToFile
{
    public void WriteLineToFile(string path, string text, string threadId)
    {
        using var streamWriter = File.AppendText("test.txt");
        streamWriter.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} : {text}");
    }
}