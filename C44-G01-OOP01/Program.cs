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
    }
}
