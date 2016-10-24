using System;

class Program
{

    static void Main()
    {
        //int symbolNumber = Console.Read();
        //int symbolNumber2 = Console.Read();
        //Console.WriteLine("{0} as character is {1}", symbolNumber, (char)symbolNumber);
        //Console.WriteLine("{0} as character is {1}", symbolNumber2, (char)symbolNumber2);

        //ConsoleKeyInfo pressedkey = Console.ReadKey();
        //Console.WriteLine("you pressed: {0}",pressedkey.KeyChar);
        //Console.WriteLine("modifier: {0}", pressedkey.Modifiers);


        //string maxnumber = Convert.ToString(long.MaxValue);
        //int number = int.Parse(maxnumber);
        //string text = "Hi, Stefan";
        //string parttext = text.Substring(0, 11);
        //Console.WriteLine(parttext);


        //int one = 1;
        //int number = 15;
        //Console.WriteLine(Convert.ToString(one, 2).PadLeft(32, '0'));
        //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        //Console.WriteLine( "--------------------------------");
        //Console.WriteLine(Convert.ToString((1&15), 2).PadLeft(32, '0'));

        //while (true)
        //{

        //    ConsoleKeyInfo keypressed = Console.ReadKey();
        //    char key_char = keypressed.KeyChar;

        //    if ('a'== key_char)
        //    {

        //        Console.WriteLine("Move down");
        //    }
        //int day = int.Parse(Console.ReadLine()); 
        // find max number
        //int a = int.Parse(Console.ReadLine());
        //int b = int.Parse(Console.ReadLine());
        //int c = int.Parse(Console.ReadLine());

        //if (a > b)
        //{
        //    if (a > c)
        //    { Console.WriteLine("Max= {0}", a);
        //    }
        //    else
        //        Console.WriteLine("Max= {0}", c);
        //}

        //else 
        //if (b > c)

        //{ Console.WriteLine("Max= {0}", b);
        //}

        //else { Console.WriteLine("Max= {0}", c); }

        //
        //int a = int.Parse(Console.ReadLine());
        //int b = int.Parse(Console.ReadLine());
        //int c = int.Parse(Console.ReadLine());


        //long product = a * b * c;

        //if (((a < 0) && (b < 0) && ((c < 0)) || ((a < 0) && (b > 0)) && (c > 0)) || ((a > 0) && (b > 0) && (c < 0))) 
        //{
        //    Console.WriteLine("Negative");

        //}
        //else

        //Console.WriteLine("Positive");

        //day of week
        int day = int.Parse(Console.ReadLine());
        switch (day)
        {
            case 1: Console.WriteLine("Monday"); break;
            case 2: Console.WriteLine("Tuesday"); break;
            case 3: Console.WriteLine("Wedsday"); break;
            case 4: Console.WriteLine("Thursday"); break;
            case 5: Console.WriteLine("Friday"); break;
            case 6: Console.WriteLine("daturday"); break;
            case 7: Console.WriteLine("Sunday"); break;

            default:  Console.WriteLine("not valid"); break;



        }






        //switch (day)
        //{
        //    case 1: Console.WriteLine("Monday"); return;
        //    case 2: Console.WriteLine("Tuesday"); break;
        //    case 3: Console.WriteLine("Wednesday"); break;
        //    case 4: Console.WriteLine("Thursday"); break;
        //    case 5: Console.WriteLine("Friday"); break;
        //    case 6: Console.WriteLine("Saturday"); break;
        //    case 7: Console.WriteLine("Sunday"); break;
        //    default: Console.WriteLine("Error!"); break;
        //}


        //    string input = Console.ReadLine();
        //    string stop = "STOP";
        //    if (input == stop)
        //    {
        //        Console.WriteLine("GAME OVER !");
        //        return;
        //    }
        //    if (input == "")
        //    {
        //        Console.WriteLine("napishi nesto idiot!");
        //    }
        //}


    }

    //        int escape_attempts = int.Parse(Console.ReadLine());

    //        long slapped_thieves = 0;
    //        long escape_thieves = 0;
    //        long total_bottles = 0;


    //        for (int i = 0; i < escape_attempts; i++)
    //        {
    //            int thieves_per_attempt = int.Parse(Console.ReadLine());
    //            int bottles = int.Parse(Console.ReadLine());


    //            if (thieves_per_attempt > 5)
    //            {
    //                escape_thieves += thieves_per_attempt - 5;
    //                slapped_thieves += 5;
    //                total_bottles += bottles;

    //            }
    //            else
    //            {
    //                slapped_thieves += thieves_per_attempt;
    //                total_bottles += bottles;
    //            }

    //        } 

    //        Console.WriteLine("{0} thieves slapped.", slapped_thieves);
    //        Console.WriteLine("{0} thieves escaped.", escape_thieves);
    //        Console.WriteLine("{0} packs, {1} bottles. ", total_bottles / 6, total_bottles % 6);



    //    }    
}

