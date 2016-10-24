using System;

class OddAndEvenProduct
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] numsString = input.Split(' ');
        int[] numsInt = new int[numsString.Length];
        for (int i = 0; i < numsString.Length; i++)
        {
            numsInt[i] = int.Parse(numsString[i]);
        }

        int oddMultiple = 1;
        int evenMultiple = 1;

        for (int i = 0; i < numsInt.Length; i++)
        {
            if ((i + 1) % 2 != 0)
                oddMultiple *= numsInt[i];
            else
                evenMultiple *= numsInt[i];
        }
        if (oddMultiple == evenMultiple)
            Console.WriteLine("yes\nproduct = {0}",oddMultiple);
        else
            Console.WriteLine("no\nodd_product = {0}\neven_product = {1}",oddMultiple,evenMultiple);
    }
}
