using System;

class JoroTheFootballPlayer
{
    static void Main()
    {
        string isLeap = Console.ReadLine();
        int numberOfHolidays = int.Parse(Console.ReadLine());
        int numberOfHometownWeekends = int.Parse(Console.ReadLine());

        double totalPlays = 0.0;
        int weeks = 52;
        int hometownPlays = numberOfHometownWeekends;
        int normalWeekends = weeks - numberOfHometownWeekends;

        double normalWeeksPlays = (normalWeekends * 2) / 3.0;
        double holidaysPlays = numberOfHolidays / 2.0;

        if (isLeap == "t")
        {
            totalPlays += 3;
        }

        totalPlays += normalWeeksPlays + holidaysPlays + hometownPlays;
        Console.WriteLine(Math.Floor(totalPlays));
    }
}

