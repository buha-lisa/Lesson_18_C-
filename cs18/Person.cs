
namespace cs18
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    public static class PersonExtensions
    {
        public static int MinAge(this Person[] people)
        {
            int min = people.Min(p => p.Age);
            return min;
        }

        public static int MaxAge(this Person[] people)
        {
            int min = people.Max(p => p.Age);
            return min;
        }

        public static double AverageAge(this Person[] people)
        {
            double avgAge = 0;
            int peopleAmount = 0;
            foreach (var person in people) 
            {
                avgAge += person.Age;
                peopleAmount += 1;
            }
            return avgAge / peopleAmount;
        }
    }
}
