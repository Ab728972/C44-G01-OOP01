namespace C44_G01_OOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        #region Question 1 - WeekDays Enum
        enum WeekDays { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

        static void PrintWeekDays()
        {
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }
        }
        #endregion
    }
}
