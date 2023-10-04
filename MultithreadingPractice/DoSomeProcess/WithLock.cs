using MultithreadingPractice.Utils;

namespace MultithreadingPractice.DoSomeProcess;

public class WithLock : ISomeProcess
{
    private readonly WriteToFile _writer = new();

    public void WriteToFile(string text, string threadId)
    {
         lock (_writer)
         {
            try
            {
                _writer.WriteLineToFile("./test.txt", text, threadId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
         }
    }
}