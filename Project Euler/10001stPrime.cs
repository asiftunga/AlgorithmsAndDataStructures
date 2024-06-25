//project euler problem number 7
//https://projecteuler.net/problem=7

class Program
{
    static void Main(string[] args)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        int counter = 0;
        int number = 3;

        while (true)
        {
            if (IsItPrimeNumber(number))
            {
                counter += 1;

                if (counter == 10000) break;
            }

            number += 2;
        }

        Console.WriteLine(number);

        stopwatch.Stop();

        long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;

        Console.WriteLine($"Program worked in {elapsedMilliseconds} ms.");
    }

    private static bool IsItPrimeNumber(int number)
    {
        double sqrtValue = Math.Sqrt(number);
        int sqrtFloor = (int)Math.Floor(sqrtValue);

        for (int i = 3; i <= sqrtFloor; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}