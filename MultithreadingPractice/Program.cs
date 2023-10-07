
using MultithreadingPractice.ApiDataFetching;
using MultithreadingPractice.DoSomeProcess;

// File.Delete("./test.txt");
// ISomeProcess withLock = new WithSemaphore();
// Parallel.For(1, 1000, (i) =>
// {
//     var threadId = Environment.CurrentManagedThreadId.ToString();
//     withLock.WriteToFile($"{i}", threadId);
//     Console.WriteLine($"{i} is done");
// });
//
// Console.WriteLine("Process completed");

var fetchClient = new SomeFetching();
var fetchingTask = Enumerable.Range(1, 100)
    .Select(i => fetchClient.FetchFromUrl($"URL: {i}"))
    .ToArray();
while (!Task.WhenAll(fetchingTask).IsCompleted)
{
    Console.WriteLine("Awaiting fetching...");
    await Task.Delay(200);
}
Console.WriteLine("FETCHED ALL DATA");
Console.ReadKey();