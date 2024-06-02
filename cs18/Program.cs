
namespace cs18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Choose number of task(1-9): ");
                int.TryParse(Console.ReadLine(), out int task);
                if (task == 0) break;

                switch (task)
                {
                    case 1:
                        int num = 8;
                        Console.WriteLine(num.PairCheck());
                        break;
                    case 2:
                        num = 8;
                        Console.WriteLine(num.UnpairCheck());
                        break;
                    case 3:
                        num = 8;
                        Console.WriteLine(num.PrimeCheck());
                        break;
                    case 4:
                        string str = "Hello world.";
                        Console.WriteLine(str.VowelsAmount());
                        break;
                    case 5:
                        str = "Hello world.";
                        Console.WriteLine(str.ConsonantsAmount());
                        break;
                    case 6:
                        str = "Hello! World.";
                        Console.WriteLine(str.SentencesAmount());
                        break;
                    case 7:
                        var people = new Person[]
                        {
                            new Person() { FirstName = "Will", LastName = "Smith", Age = 30 },
                            new Person() { FirstName = "Jonny", LastName = "Dep", Age = 50 },
                            new Person() { FirstName = "Elena", LastName = "Brown", Age = 15 },
                        };
                        foreach (var person in people)
                        {
                            File.AppendAllText("People.txt", person.FirstName);
                            File.AppendAllText("People.txt", person.LastName);
                            File.AppendAllText("People.txt", person.Age.ToString());
                        }

                        Console.WriteLine($"The maximum age: {people.MinAge()}");
                        Console.WriteLine($"The maximum age: {people.MaxAge()}");
                        Console.WriteLine($"Average age of people: {people.AverageAge()}");
                        break;
                    case 8:
                        var points = new Point3D[]
                        {
                            new Point3D() { X = 1, Y = 4, Z = -2 },
                            new Point3D() { X = -1, Y = -3, Z = 5 },
                            new Point3D() { X = 0, Y = 0, Z = 0 },
                        };
                        foreach (var point in points)
                        {
                            File.AppendAllText("Points.txt", point.X.ToString());
                            File.AppendAllText("Points.txt", point.Y.ToString());
                            File.AppendAllText("Points.txt", point.Z.ToString());
                            File.AppendAllText("Points.txt", "\n");
                        }
                        points.FindMaxDistance();
                        break;
                    case 9:
                        var fractions = new Fraction[]
                        {
                            new Fraction() { Numerator = 1, Denominator = 2},
                            new Fraction() { Numerator = 3, Denominator = 4},
                            new Fraction() { Numerator = 8, Denominator = 6},
                        };
                        foreach (var fraction in fractions)
                        {
                            File.AppendAllText("Fractions.txt", fraction.Numerator.ToString());
                            File.AppendAllText("Points.txt", fraction.Denominator.ToString());
                            File.AppendAllText("Points.txt", "\n");
                        }
                        Console.WriteLine($"Minimum fraction: {fractions.MinFraction()}");
                        Console.WriteLine($"Maximum fraction: {fractions.MaxFraction()}");
                        break;
                }
            }
        }
    }
    //public static class StringExtensions
    //{
    //    public static string AddOne(this string str)
    //    {
    //        return str + " One";
    //    }

    //    public static string StringToBinary(this string str)
    //    {
    //        var binaryString = "";

    //        foreach (char c in str)
    //        {
    //            string binaryChar = Convert.ToString(c, 2).PadLeft(8, '0');
    //            binaryString += binaryChar + " ";
    //        }

    //        return binaryString;
    //    }

    //    public static string ReplaceAtPositions(this string source, List<int> positions, char replacement)
    //    {
    //        var result = "";
    //        foreach (var pos in positions)
    //        {
    //            if (pos >= 0 && pos < source.Length)
    //            {
    //                result += replacement;
    //            }
    //        }
    //        return result;
    //    }

    //    public static string CapitalizeVowels(this string input)
    //    {
    //        var result = "";
    //        foreach (char c in input)
    //        {
    //            if ("aeiou".Contains(char.ToLower(c)))
    //            {
    //                result += char.ToUpper(c);
    //            }
    //            else
    //            {
    //                result += c;
    //            }
    //        }
    //        return result;
    //    }
    //}
}
