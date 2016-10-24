using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BaiIvanAdventures
{
    class BaiIvanAdventures
    {
        static void Main(string[] args)
        {
            int dayOfWeek = int.Parse(Console.ReadLine());
            decimal money = decimal.Parse(Console.ReadLine());
            decimal desiredAlcohol = decimal.Parse(Console.ReadLine());
            decimal boughtAlcohol = 0;
            string status;
            switch (dayOfWeek)
            {
                case 0: boughtAlcohol = money / 25m; break;
                case 1: boughtAlcohol = money / 21m; break;
                case 2: boughtAlcohol = money / 14m; break;
                case 3: boughtAlcohol = money / 17m; break;
                case 4: boughtAlcohol = money / 45m; break;
                case 5: boughtAlcohol = money / 59m; break;
                case 6: boughtAlcohol = money / 42m; break;
            }
            if (boughtAlcohol > 1.5m)
            {
                status = "very drunk";
            }
            else if (boughtAlcohol >= 1m)
            {
                status = "drunk";
            }
            else
            {
                status = "sober";
            }
            if (boughtAlcohol > desiredAlcohol)
            {
                Console.WriteLine("Bai Ivan is {0} and very happy and he shared {1:F2} l. of alcohol with his friends",
                    status, boughtAlcohol - desiredAlcohol);
            }
            else if (boughtAlcohol == desiredAlcohol)
            {
                Console.WriteLine("Bai Ivan is {0} and happy. He is as drunk as he wanted", status);
            }
            else
            {
                Console.WriteLine("Bai Ivan is {0} and quite sad. He wanted to drink another {1:F2} l. of alcohol",
                    status, desiredAlcohol - boughtAlcohol);
            }
        }
    }
}
