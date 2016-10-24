using System;
using System.Numerics;

class TrailingZeroesInNFact
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger factN = 1;
        for (int i = 1; i <= n; i++)
        {
            factN *= i;
        }
        int counter = 0;
        BigInteger lastNumber = factN % 10;
        while (lastNumber == 0)
        {
            counter++;
            factN /= 10;
            lastNumber = factN % 10;
        }
        Console.WriteLine(counter);
    }
}
