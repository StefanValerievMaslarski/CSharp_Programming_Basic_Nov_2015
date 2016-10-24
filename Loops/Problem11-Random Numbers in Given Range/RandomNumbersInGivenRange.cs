using System;

class RandomNumbersInGivenRange
{
    static void Main(string[] args)
    {
        int n, min, max;
        
        do
        {
            Console.Write("Input N: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Input Min: ");
            min = int.Parse(Console.ReadLine());
            Console.Write("Input Max: ");
            max = int.Parse(Console.ReadLine());
        }while(min >= max);
        Random rand = new Random();
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(rand.Next(min,max+1));
        }

    }
}
