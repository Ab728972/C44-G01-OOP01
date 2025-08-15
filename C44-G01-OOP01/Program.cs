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
        #region Question 2 - Person Struct
        struct Person
        {
            public string Name;
            public int Age;
        }

        static void DisplayPersons()
        {
            Person[] people = new Person[3];
            people[0] = new Person { Name = "Ahmed", Age = 25 };
            people[1] = new Person { Name = "Mohamed", Age = 30 };
            people[2] = new Person { Name = "Fatima", Age = 22 };

            foreach (var person in people)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
        }
        #endregion
        #region Question 3 - Seasons Enum
        enum Season { Spring, Summer, Autumn, Winter }

        static void DisplaySeasonMonths()
        {
            Console.Write("Enter season: ");
            string input = Console.ReadLine();

            if (Enum.TryParse(input, true, out Season season))
            {
                switch (season)
                {
                    case Season.Spring:
                        Console.WriteLine("March - May");
                        break;
                    case Season.Summer:
                        Console.WriteLine("June - August");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("September - November");
                        break;
                    case Season.Winter:
                        Console.WriteLine("December - February");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid season");
            }
        }
        #endregion
        #region Question 4 - Colors Enum
        enum Colors { Red, Green, Blue }

        static void CheckPrimaryColor()
        {
            Console.Write("Enter color: ");
            string input = Console.ReadLine();

            if (Enum.TryParse(input, true, out Colors color))
            {
                Console.WriteLine($"{color} is a primary color");
            }
            else
            {
                Console.WriteLine("Not a primary color");
            }
        }
        #endregion
    }
}
