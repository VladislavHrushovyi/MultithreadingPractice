
using MultithreadingPractice.DoSomeProcess;

File.Delete("./test.txt");
ISomeProcess withLock = new WithMutex();
Parallel.For(1, 1000, (i) =>
{
    var threadId = Environment.CurrentManagedThreadId.ToString();
    withLock.WriteToFile($"{i}", threadId);
    Console.WriteLine($"{i} is done");
});

Console.WriteLine("Process completed");
Console.ReadKey();