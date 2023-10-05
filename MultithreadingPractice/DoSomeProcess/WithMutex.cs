using MultithreadingPractice.Utils;

namespace MultithreadingPractice.DoSomeProcess;

public class WithMutex : ISomeProcess
{
    private readonly Mutex _mutex = new();
    private readonly WriteToFile _writer = new();
    public void WriteToFile(string text, string threadId)
    {
        _mutex.WaitOne();
        try
        {
            _writer.WriteLineToFile("./test.txt", text, threadId);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        finally
        {
            _mutex.ReleaseMutex();
        }
    }
}