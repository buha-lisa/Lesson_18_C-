
namespace cs18
{
    public class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }
        public double ToDouble()
        {
            return (double)Numerator / Denominator;
        }
        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
    public static class FractionExtensions
    {
        public static Fraction MinFraction(this Fraction[] fractions)
        {
            var minFraction = fractions[0];
            foreach (var fraction in fractions)
            {
                if (fraction.ToDouble() < minFraction.ToDouble())
                {
                    minFraction = fraction;
                }
            }
            return minFraction;
        }

        public static Fraction MaxFraction(this Fraction[] fractions)
        {
            var maxFraction = fractions[0];
            foreach (var fraction in fractions)
            {
                if (fraction.ToDouble() > maxFraction.ToDouble())
                {
                    maxFraction = fraction;
                }
            }
            return maxFraction;
        }
    }
}
