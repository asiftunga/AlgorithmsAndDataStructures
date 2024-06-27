//project euler problem number 10
//https://projecteuler.net/problem=10

public class Program
{
    public static void Main(string[] args)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        long sum = 0;

        for (long i = 3; i <2000000 ; i+=2)
        {
            if (IsItPrimeNumber(i))
            {
                sum += i;
            }
        }

        Console.WriteLine(sum + 2);

        stopwatch.Stop();

        long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;

        Console.WriteLine($"Program worked in {elapsedMilliseconds} ms.");
    }

    private static bool IsItPrimeNumber(long number)
    {
        double sqrtValue = Math.Sqrt(number);
        int sqrtFloor = (int)Math.Floor(sqrtValue);

        for (int i = 3; i <= sqrtFloor; i+= 2)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}