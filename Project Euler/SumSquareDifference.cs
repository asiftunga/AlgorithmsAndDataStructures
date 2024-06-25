//project euler problem number 6
//https://projecteuler.net/problem=6

class Program
{
    static void Main(string[] args)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        
        //1^2 + 2^2 + 3^2 + .... + n^2 = n(n+1)(2n+1)/6

        int x = 100 * 101 / 2;

        long sumOfSquares = 100 * 101 * 201 / 6;

        long difference = Math.Abs(sumOfSquares - x*x);

        Console.WriteLine(difference);

        stopwatch.Stop();

        long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;

        Console.WriteLine($"Program worked in {elapsedMilliseconds} ms.");
    }
}