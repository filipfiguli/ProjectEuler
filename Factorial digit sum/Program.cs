namespace Factorial_digit_sum;

class Program
{
    static void Main(string[] args)
    {
        List<int> result = new List<int>() { 1 };

        for (int i = 1; i <= 100; i++)
        {
            result = Multiply(result, MakeDigitList(i));
        }

        Console.WriteLine(result.Sum());
    }

    static List<int> MakeDigitList(int x)
    {
        List<int> output = new List<int>();

        int length = x.ToString().Length;
        for (int i = 1; i <= length; i++)
        {
            output.Add(x % 10);
            x /= 10;
        }

        return output.Reverse<int>().ToList();
    }

    static List<int> Multiply(List<int> a, List<int> b)
    {
        List<int> output = new List<int>();

        a = a.Reverse<int>().ToList();
        b = b.Reverse<int>().ToList();

        for (int i = 0; i < a.Count; i++)
        {
            List<int> tmp = new List<int>();

            for (int x = 0; x < i; x++)
            {
                tmp.Add(0);
            }

            int carry = 0;
            for (int j = 0; j < b.Count; j++)
            {
                int sum = a[i] * b[j] + carry;
                int digit = sum % 10;
                carry = sum / 10;
                tmp.Add(digit);
            }

            if (carry > 0)
            {
                tmp.Add(carry);
            }

            output = ReverseSum(output, tmp);
        }

        return output.Reverse<int>().ToList();
    }

    static List<int> ReverseSum(List<int> a, List<int> b)
    {
        return Sum(a.Reverse<int>().ToList(), b.Reverse<int>().ToList()).Reverse<int>().ToList();
    }

    static List<int> Sum(List<int> a, List<int> b)
    {
        List<int> output = new List<int>();

        a = a.Reverse<int>().ToList();
        b = b.Reverse<int>().ToList();

        // a.Count < b.Count ? ak je TRUE : ak je FALSE;
        List<int> longerNumber = a.Count > b.Count ? a : b;
        List<int> shortNumber = a.Count > b.Count ? b : a;

        int carry = 0;
        for (int i = 0; i < longerNumber.Count; i++)
        {
            int sum;

            // Vyriesime ak uz sme dalej ako dlzka kratkeho cisla
            if (i >= shortNumber.Count)
            {
                sum = longerNumber[i] + carry;
            }
            // Este stale mame priestor v kratkom cisle
            else
            {
                sum = longerNumber[i] + shortNumber[i] + carry;
            }

            int digit = sum % 10;
            carry = sum / 10;

            output.Add(digit);
        }

        if (carry > 0)
        {
            output.Add(carry);
        }

        return output.Reverse<int>().ToList();
    }
}