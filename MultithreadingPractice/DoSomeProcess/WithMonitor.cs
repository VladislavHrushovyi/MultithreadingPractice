using MultithreadingPractice.Utils;

namespace MultithreadingPractice.DoSomeProcess;

public class WithMonitor : ISomeProcess
{
    private readonly WriteToFile _writer = new();


    public void WriteToFile(string text, string threadId)
    {
        Monitor.Enter(_writer);
        try
        {
            _writer.WriteLineToFile("./test.txt", text, threadId);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Monitor.Exit(_writer);
            throw;
        }
        finally
        {
            Monitor.Exit(_writer);   
        }
    }
}