namespace Smallest_multiple;

class Program
{
    static void Main(string[] args)
    {
        int number = 2520;

        // Iterate over numbers until we find one that will be divisible
        while (!IsDivisible(number))
        {
            number++;
        }

        Console.WriteLine(number);
    }

    // Check if number is divisible by all numbers 1..20
    static bool IsDivisible(int number)
    {
        for (int i = 1; i <= 20; i++)
        {
            if (number % i != 0)
            {
                return false;
            }
        }

        return true;
    }
}

