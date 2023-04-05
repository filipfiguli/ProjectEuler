namespace Even_Fibonacci_numbers;

class Program
{
    static void Main(string[] args)
    {
        int a = 0;
        int b = 1;
        int c = 1;

        // Keep track of sum during calculation
        int sum = a + b;

        // Stop once the value of last Fibonnaci number exceeds 4 000 000
        while(c < 4000000)
        {
            // Sum um all even Fibonnaci numbers
            if (c % 2 == 0)
            {
                sum += c;
            }

            // Calculate Fibonnaci numbers
            a = b;
            b = c;
            c = a + b;
        }

        Console.WriteLine(sum);
    }
}

