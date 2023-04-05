namespace _10001st_prime;

class Program
{
    static void Main(string[] args)
    {
        int count = 0;
        int x = 1;

        // If we found the 10001th prime end and print to console
        while (count != 10001)
        {
            // To start with first prime number (2) we have to start with x = 1
            x++;

            // If is prime then increment count (number of primes we found)
            if (IsPrime(x))
            {
                count++;
            }
        }

        Console.WriteLine(x);
    }

    // Check if number is a prime
    static bool IsPrime(int number)
    {
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}

