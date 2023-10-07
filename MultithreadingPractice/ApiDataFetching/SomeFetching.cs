namespace MultithreadingPractice.ApiDataFetching;

public class SomeFetching
{
    private readonly Random _random = new();

    public async Task FetchFromUrl(string url)
    {
        await Task.Delay(_random.Next(1000, 10000)); // some fetching

        Console.WriteLine("Data from url: " + url);
    }
}