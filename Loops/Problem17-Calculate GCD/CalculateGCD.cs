using System;

class CalculateGCD
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        while (a != 0 && b != 0)
        {


            if (Math.Abs(a) > Math.Abs(b))
                a %= b;
            else
                b %= a;
        }

        if (a == 0)
        {
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine(a);
        }
    }
}
