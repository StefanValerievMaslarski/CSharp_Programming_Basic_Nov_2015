using System;

class DecimalToBinaryNumber
{
    static void Main(string[] args)
    {
        Console.Write("Enter decimal number: ");
        long input = long.Parse(Console.ReadLine());
        int index = 0;
        string output = "";
        while (input != 0)
        {
            if (input % 2 == 1)
            {
                output = Convert.ToString(input % 2) + output;
                input /= 2;
            }
            else
            {
                output = Convert.ToString(input % 2) + output;
                input /= 2;
            }
            index++;
            arraySize++;
        }
        Console.WriteLine(output);
    }
}
