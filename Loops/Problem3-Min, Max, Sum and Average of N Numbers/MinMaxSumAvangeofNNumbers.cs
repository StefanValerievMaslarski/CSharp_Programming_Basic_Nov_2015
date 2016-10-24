using System;

class MinMaxSumAvangeofNNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];
        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }
        for (int write = 0; write < nums.Length; write++)
        {
            for (int sort = 0; sort < nums.Length - 1; sort++)
            {
                if (nums[sort] > nums[sort + 1])
                {
                    int temp = nums[sort + 1];
                    nums[sort + 1] = nums[sort];
                    nums[sort] = temp;
                }
            }
        }
        double sum = 0;
        
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        double avg = sum;
        avg = sum / n;
        
        Console.WriteLine("Max: {0}",nums[n-1]);
        Console.WriteLine("Min: {0}",nums[0]);
        Console.WriteLine("Sum: {0}",sum);
        Console.WriteLine("Avg: {0:0.00}",avg);
    }
}
