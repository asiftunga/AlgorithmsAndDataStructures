//project euler problem number 3
//https://projecteuler.net/problem=3

class Program
{
    static void Main(string[] args)
    {
        long number = 600_851_475_143;

        int i = 2;

        List<int> primeFactors = new();

        while (true)
        {
            if (number % i != 0)
            {
                i = FindNextPrimeNumber(i+1);

                continue;
            }

            number /= i;

            primeFactors.Add(i);

            if (number == 1)
            {
                break;
            }
        }

        Console.WriteLine(string.Join(",", primeFactors));
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