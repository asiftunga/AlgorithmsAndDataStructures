//project euler problem number 2
//https://projecteuler.net/problem=2

class Program
{
    static void Main(string[] args)
    {
        int i = 1;
        int j = 2;
        int sum = 0;
        int temp = 0;

        while (temp <= 4_000_000)
        {
            temp = i;

            i = j;

            j += temp;

            if (temp % 2 == 0)
            {
                sum += temp;
            }
        }

        Console.WriteLine(sum);
    }
}