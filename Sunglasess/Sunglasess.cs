using System;

class Sunglasess
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        int height = inputNumber;
        
        string frame = new string('*', inputNumber * 2);
        string spaceBetween = new string(' ', inputNumber);

        Console.WriteLine("{0}{1}{0}", frame, spaceBetween);
        for (int row = 1; row <= inputNumber - 2; row++)
        {
            string glass = "*" + new string('/', (inputNumber * 2) - 2) + "*";

            if ((height / 2) == row)
            {
                string bridge = new string('|', inputNumber);
                Console.WriteLine("{0}{1}{0}", glass, bridge);
            }
            else
            {
                Console.WriteLine("{0}{1}{0}", glass, spaceBetween);
            }
        }
        Console.WriteLine("{0}{1}{0}", frame, spaceBetween);
    }
}

