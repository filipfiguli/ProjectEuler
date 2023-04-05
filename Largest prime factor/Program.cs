namespace Largest_prime_factor;

class Program
{
    static void Main(string[] args)
    {
        long number = 600851475143;

        int largestFactor = 0;
        for (int i = 2; i <= number; i++)
        {
            // Check if the number is divisible by i
            if (number % i == 0)
            {
                // Save i as largest factor
                largestFactor = i;

                // Get rid of remaining factors of the same value
                while (number % i == 0)
                {
                    number /= i;
                }
            }
        }

        Console.WriteLine(largestFactor);
    }
}