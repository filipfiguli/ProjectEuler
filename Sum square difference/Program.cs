namespace Sum_square_difference;

class Program
{
    static void Main(string[] args)
    {
        long squareOfSum = 0;
        long sumOfSquares = 0;

        for (long i = 1; i <= 100; i++)
        {
            sumOfSquares += (long) Math.Pow(i, 2);
            squareOfSum += i;
        }

        Console.WriteLine(Math.Pow(squareOfSum, 2) - sumOfSquares);
    }
}

