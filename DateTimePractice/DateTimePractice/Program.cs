using System;

namespace DateTimePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTimePractice();
            CompareToDateTimePractice();
        }
        public static void DateTimePractice()
        {
            DateTime today = DateTime.Now;
            DateTime myFakeBirthday = new DateTime(1970, 1, 1);
            DateTime bestFakeDayEver = myFakeBirthday;

            int currentMonth = today.Month;
            int currentDay = today.Day;
            int currentYear = today.Year;

            int currentHour = today.Hour;
            int currentMinute = today.Minute;
            int currentSecond = today.Second;

            Console.WriteLine($"The day of the week: {today.DayOfWeek}");
            Console.WriteLine($"The day of the year: {today.DayOfYear}");
            Console.WriteLine($"Short string: {today.ToShortDateString()}");
            Console.WriteLine($"Current Month: {currentMonth}");
            Console.WriteLine($"Current day: {currentDay}");
            Console.WriteLine($"Current year: {currentYear}");
            Console.WriteLine($"Current hour: {currentHour}");
            Console.WriteLine($"Current minute: {currentMinute}");
            Console.WriteLine($"Current second: {currentSecond}");
            Console.WriteLine($"Fake birthday: {bestFakeDayEver.ToShortDateString()}");

            Console.WriteLine($"In 7 years the date will be: {today.AddYears(7).ToShortDateString()}");
            Console.WriteLine($"In 87 months the date will be: {today.AddMonths(87).ToShortDateString()}");
            Console.WriteLine($"In 336 days the date will be: {today.AddDays(336).ToShortDateString()}");

            Console.WriteLine($"In 10 mins the time will be: {today.AddMinutes(10)}");
            Console.WriteLine($"In 2 hours the time will be: {today.AddHours(2)}");
            Console.WriteLine($"In 55 seconds the time will be: {today.AddSeconds(55)}");
        }
        public static void CompareToDateTimePractice()
        {
            DateTime today = DateTime.Now;
            DateTime lastWeek = today.AddDays(-7);
            DateTime NextWeek = today.AddDays(7);
            Console.WriteLine($"Compare to today: {today.CompareTo(today)}. Zero means equal to");
            Console.WriteLine($"Compare to last week: {today.CompareTo(lastWeek)}. 1 means later than the second value");
            Console.WriteLine($"Compare to next week: {today.CompareTo(NextWeek)}. -1 means earlier than");
        }
    }
}
