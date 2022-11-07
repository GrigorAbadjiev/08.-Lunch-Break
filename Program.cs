using System;

namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string serialName = Console.ReadLine();
            int serialTime = int.Parse(Console.ReadLine());
            int lunchBreakTime = int.Parse(Console.ReadLine());

            double lunchTime = lunchBreakTime / 8.0;
            double breakTime = lunchBreakTime / 4.0;
            double timeForSeials = lunchBreakTime - (lunchTime + breakTime);
            double difference = timeForSeials - serialTime;

            if(difference >= 0)
            {
                difference = Math.Ceiling(difference);
                Console.WriteLine($"You have enough time to watch {serialName} and left with {difference} minutes free time.");
            }
            else
            {
                difference = Math.Abs(difference);
                difference = Math.Ceiling(difference);
                Console.WriteLine($"You don't have enough time to watch {serialName}, you need {difference} more minutes.");
            }



        }
    }
}
