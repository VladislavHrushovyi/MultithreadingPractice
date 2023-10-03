
using MultithreadingPractice.DoSomeProcess;

WithLock withLock = new WithLock();
Parallel.For(1, 100, (i) =>
{
    withLock.WriteToFile(Task.CurrentId.ToString(), $"{i}");
    Console.WriteLine($"{i} is done");
});

Console.WriteLine("Process with lock completed");
Console.ReadKey();