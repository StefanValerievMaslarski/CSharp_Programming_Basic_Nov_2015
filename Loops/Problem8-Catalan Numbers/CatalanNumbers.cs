using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main(string[] args)
    {
        int n;
        do
        {
            Console.Write("Input N  0 < n < 100: ");
            n = int.Parse(Console.ReadLine());
        } while (n < 0 || n > 99);
        BigInteger factN = 1;
        BigInteger factNplus1 = 1;
        BigInteger factNmultiplied2 = 1;
        for (int i = 1; i < (n*2)+1; i++)
        {
            factNmultiplied2 *= i;
        }
        for (int i = 1; i < n+1+1; i++)
        {
            factNplus1 *= i;
        }
        for (int i = 1; i < n+1; i++)
        {
            factN *= i;
        }
        BigInteger result = factNmultiplied2 / (factNplus1 * factN);
        Console.WriteLine(result);
    }
}
