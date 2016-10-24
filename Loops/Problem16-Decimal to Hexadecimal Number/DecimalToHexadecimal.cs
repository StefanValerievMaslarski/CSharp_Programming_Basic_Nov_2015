using System;

class DecimalToHexadecimal
{
    static void Main(string[] args)
    {
        long input = long.Parse(Console.ReadLine());
        char[] hex = new char[6] { 'A', 'B', 'C', 'D', 'E', 'F' };
        string output = "";
        while (input != 0)
        {
            if (input % 16 < 10)
            {
                output = Convert.ToString(input % 16) + output;
                input /= 16;
            }
            else
            {
                output = Convert.ToString(hex[(input % 16) - 10]) + output;
                input /= 16;
            }
        }
        Console.WriteLine(output);
    }
}
