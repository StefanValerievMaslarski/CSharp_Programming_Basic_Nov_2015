using System;

class PrintADeckOf52Cards
{
    static void Main(string[] args)
    {
        string[] cards = new string[13] {"2","3","4","5","6","7","8","9","10","J","Q","K","A"};
        char[] suits = new char[4] { '\u0005', '\u0004', '\u0003', '\u0006' };
        for (int i = 0; i < cards.Length; i++)
        {
            for (int j = 0; j < suits.Length; j++)
            {
                switch (j)
                {
                    case 0:
                        Console.Write("{0}{1} ",cards[i],suits[j]);
                        break;
                    case 1:
                        Console.Write("{0}{1} ", cards[i], suits[j]);
                        break;
                    case 2:
                        Console.Write("{0}{1} ", cards[i], suits[j]);
                        break;
                    case 3:
                        Console.WriteLine("{0}{1} ", cards[i], suits[j]);
                        break;
                }
            }
        }
    }
}
