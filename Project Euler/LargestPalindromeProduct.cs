//project euler problem number 4
//https://projecteuler.net/problem=4

class Program
{
    static void Main(string[] args)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        //biggest number from product of two 3-digit number is -> 999 x 999 = 998_001, so I need to look 6-digit numbers
        //sample => IJKKJI = 100_001I + 10_010J + 1_100K

        int number = 0;
        bool flag = true;

        for (int i = 9; i > 0 && flag; i--)
        {
            for (int j = 9; j >= 0 && flag; j--)
            {
                for (int k = 9; k >= 0 && flag; k--)
                {
                    number = 100_001*i + 10_010*j + 1_100*k;

                    if (IsThreeDigitProduct(number))
                    {
                        flag = false;
                    }
                }
            }
        }

        Console.WriteLine($"final number : {number}");

        stopwatch.Stop();

        long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;

        Console.WriteLine($"Program worked in {elapsedMilliseconds} ms.");
    }

    private static bool IsThreeDigitProduct(int number)
    {
        for (int i = 100; i <= 999; i++)
        {
            if (number % i == 0 && number / i >= 100 && number / i <= 999)
            {
                return true;
            }
        }

        return false;
    }
}