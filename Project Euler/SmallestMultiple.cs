//project euler problem number 5
//https://projecteuler.net/problem=5
//i want to solve this problem with LCM

class Program
{
    static void Main(string[] args)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        List<List<int>> prime = new();
        int count, lcmNumber = 1;
        List<int> controlledItems = new();

        for (int j = 2; j <= 20; j++)
        {
            int i = 2;

            int number = j;

            List<int> primeFactors = new();

            while (true)
            {
                if (number % i != 0)
                {
                    i = FindNextPrimeNumber(i + 1);

                    continue;
                }

                number /= i;

                primeFactors.Add(i);

                if (number == 1)
                {
                    prime.Add(primeFactors);

                    break;
                }
            }
        }

        for (int i = 0; i < prime.Count; i++)
        {
            for (int j = 0; j < prime[i].Count; j++)
            {
                if (controlledItems.All(x => x != prime[i][j]))
                {
                    int biggest = 0;

                    for (int k = 0; k < prime.Count; k++)
                    {
                        count = prime[k].Count(x => x == prime[i][j]);

                        if (count > biggest)
                        {
                            biggest = count;
                        }
                    }

                    for (int k = 1; k <= biggest; k++)
                    {
                        lcmNumber *= prime[i][j];
                    }

                    controlledItems.Add(prime[i][j]);
                }
            }
        }

        string result = "[" + string.Join(", ", prime.Select(row => "{" + string.Join(", ", row) + "}")) + "]";

        Console.WriteLine(result);

        Console.WriteLine(lcmNumber);

        stopwatch.Stop();

        long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;

        Console.WriteLine($"Program worked in {elapsedMilliseconds} ms.");
    }

    private static int FindNextPrimeNumber(int number)
    {
        if (!IsItPrimeNumber(number))
        {
            FindNextPrimeNumber(++number);
        }

        return number;
    }

    private static bool IsItPrimeNumber(int number)
    {
        double sqrtValue = Math.Sqrt(number);
        int sqrtFloor = (int)Math.Floor(sqrtValue);

        for (int i = 2; i <= sqrtFloor; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}