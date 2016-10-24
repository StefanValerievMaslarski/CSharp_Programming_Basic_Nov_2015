using System;

class MatrixOfNumbers
{
    static void Main(string[] args)
    {
        int n;
        do
        {
            Console.Write("Input N: ");
            n = int.Parse(Console.ReadLine());
        }while (n < 1 || n > 20);
        for (int i = 1; i < n+1; i++)
        {
            for (int j = i; j < n+i; j++)
            {
                if (j == n + i - 1)
                {
                    Console.WriteLine(j);
                }
                else
                {
                    Console.Write("{0} ",j);
                }
            }
        }
    }
}
