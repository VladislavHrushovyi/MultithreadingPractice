using MultithreadingPractice.Utils;

namespace MultithreadingPractice.DoSomeProcess;

public class WithSemaphore : ISomeProcess
{
    private readonly Semaphore _semaphore = new(5, 5);
    private readonly WriteToFile _writer = new();
    public void WriteToFile(string text, string threadId)
    {
        _semaphore.WaitOne();
        try
        {
            _writer.WriteLineToFile("./test.txt", text, threadId);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            _semaphore.Release();
        }
    }
}