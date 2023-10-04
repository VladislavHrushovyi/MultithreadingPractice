
using MultithreadingPractice.DoSomeProcess;

ISomeProcess withLock = new WithMonitor();
Parallel.For(1, 100, (i) =>
{
    var threadId = Thread.CurrentThread.ManagedThreadId.ToString();
    withLock.WriteToFile($"{i}", threadId);
    Console.WriteLine($"{i} is done");
});

Console.WriteLine("Process with monitor completed");
Console.ReadKey();