namespace Date
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            Date date = new Date {Day = 1, Month = 1, Year= 2016 };
            Console.WriteLine(date.Remove(64));
        }
    }
}
