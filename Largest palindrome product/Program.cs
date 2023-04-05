namespace Largest_palindrome_product;

class Program
{
    static void Main(string[] args)
    {
        // Try all possible combination of numbers
        int largestPalindrome = 0;
        for (int i = 100; i < 1000; i++)
        {
            for (int j = 100; j < 1000; j++)
            {
                // Check if number is palindrome if yes check if it is greater then last palindrome we found
                int number = i * j;
                if (IsPalindrome(number) && number > largestPalindrome)
                {
                    largestPalindrome = number;
                }
            }
        }

        Console.WriteLine(largestPalindrome);
    }

    // Check if number is a palindrome
    static bool IsPalindrome(int number)
    {
        string numberAsText = number.ToString();
        int numberOfDigits = numberAsText.Length;

        // Compare first and last digit (then second and second last... etc)
        for (int i = 0; i < numberOfDigits / 2; i++)
        {
            if (numberAsText[i] != numberAsText[numberOfDigits - 1 - i])
            {
                return false;
            }
        }

        return true;
    }
}

