using System;

class BinaryToDecimal
{
    static void Main(string[] args)
    {
        long result = 0;
        int num;
        Console.Write("The input must be binary number: ");
        string input = Console.ReadLine();
        for (int i = input.Length-1, j = 0; i >= 0; i--, j++)
        {
            int parse = int.Parse(Convert.ToString(input[i]));
            if (parse == 1)
            {
                num = (int)Math.Pow(2, j);
                result += num;
            }
        }
        Console.WriteLine(result);
    }
}
