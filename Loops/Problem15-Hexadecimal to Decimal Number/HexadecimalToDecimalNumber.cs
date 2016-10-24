using System;

class HexadecimalToDecimalNumber
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        char[] hex = new char[6] { 'A','B','C','D','E','F' };

        long result = 0;
        for (int i = input.Length-1, j = 0 ; i >= 0; i--,j++)
        {
            double num;
            if (double.TryParse(Convert.ToString(input[i]), out num))
            {
                num = num*Math.Pow(16,j);
                result += (long)num;
            }
            else
            {
                for (int z = 0; z < hex.Length; z++)
                {
                    if (hex[z] == char.ToUpper(input[i]))
                    {
                        num = z + 10;
                        num = num*Math.Pow(16, j);
                        result += (long)num;
                        break;
                    }
                }
            }
        }
        Console.WriteLine(result);
    }
}
