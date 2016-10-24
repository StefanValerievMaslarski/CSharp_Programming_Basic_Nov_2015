using System;
using System.Numerics;

class Calculate
{
    static void Main(string[] args)
    {
        int n, k;
        do
        {
            Console.Write("Въведете N 1 < n < 100: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Въведете K 1 < k < n < 100: ");
            k = int.Parse(Console.ReadLine());
        }
        while (n < k || (n > 100 || k > 100) || (n < 1 || k < 1));
        BigInteger factN = 1;
        BigInteger factK = 1;
        BigInteger factNK = 1;
        for (int i = 1; i < n+1; i++)
        {
            factN *= i;
        }
        for (int i = 1; i < k+1; i++)
        {
            factK *= i;
        }
        for (int i = 1; i < n-k+1; i++)
        {
            factNK *= i;
        }
        BigInteger result = factN / (factK * factNK);
        Console.WriteLine(result);
    }
}
