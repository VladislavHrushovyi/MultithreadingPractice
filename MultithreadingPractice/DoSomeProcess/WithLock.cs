namespace MultithreadingPractice.DoSomeProcess;

public class WithLock
{
    private readonly object _lockObj = new();
    public WithLock()
    {
        
    }

    public void WriteToFile(string nameThread, string text)
    {
         lock (_lockObj)
         {
            try
            {
                using var streamWriter = File.AppendText("test.txt");
                streamWriter.WriteLine($"Thread {nameThread} : {text}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
         }
    }
}