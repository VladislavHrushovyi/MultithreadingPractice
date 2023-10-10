namespace MultithreadingPractice.DoSomeProcess;

public class Interlocked
{
    private int _counter = 0;

    public int Count => _counter;

    public void SomeProcess(int number)
    {
        if (number % 2 == 0)
        {
            System.Threading.Interlocked.Increment(ref _counter);
        }
    }
}