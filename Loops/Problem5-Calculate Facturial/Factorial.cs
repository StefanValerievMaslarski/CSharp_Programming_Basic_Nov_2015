using System;

class Factorial
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        double xPow = 1;
        double factN = 1;
        double result = 0;
        for (int i = 1; i <= n; i++)
        {
            factN *= i;
            xPow *= x;
            result += (factN / xPow);
        }
        Console.WriteLine("{0:0.00000}",1 + result);
    }
}
