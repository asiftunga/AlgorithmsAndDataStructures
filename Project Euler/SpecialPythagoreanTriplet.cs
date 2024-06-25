//project euler problem number 9
//https://projecteuler.net/problem=9

class Program
{
    static void Main(string[] args)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        int number = CalculateNumbers();

        Console.WriteLine(number);

        stopwatch.Stop();

        long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;

        Console.WriteLine($"Program worked in {elapsedMilliseconds} ms.");
    }
    
    //a < b < c, so c is hypotenuse -> 1000/3 => 333.. if all sides were equal c = 333.. but c is larger than all of them, for b -> its larger than a so remaining value would be shared if the two sides were equal, but since b is larger b needs to be more than half of the remaining value.
    private static int CalculateNumbers()
    {
        for (int c = 997; c > 1000/3; c--) //for largest case c = 997 b = 2 and c = 1
        {
            for (int b = 1000 - c -1; b > (1000 - c)/2; b--) //minus 1 for the a
            {
                for (int a = 1000 - c - b; a > 0; a--)
                {
                    if(a + b + c == 1000 && (Math.Pow(a,2) + Math.Pow(b,2) == Math.Pow(c,2)))
                    {
                        return a*b*c;
                    }
                }
            }
        }

        return 0;
    }
}