using System;

class RandomizeTheNumbers1toN
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Random rand = new Random();
        for (int i = 0; i < n; i++)
        {
            Console.Write(rand.Next(1,n+1) + " ");
        }
    }
}
