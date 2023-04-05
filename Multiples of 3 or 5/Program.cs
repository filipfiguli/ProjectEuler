namespace Multiples_of_3_or_5;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0;

        // Iterate through all numbers belowe 1000
        for (int i = 1; i < 1000; i++)
        {
            // If i is multiple of 3 or 5 add it to the sum
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += i;
            }
        }

        Console.WriteLine(sum);
    }
}