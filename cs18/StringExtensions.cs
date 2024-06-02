namespace cs18
{
    public static class StringExtensions
    {
        public static int VowelsAmount(this string str) 
        {
            var result = 0;
            str = str.ToLower();
            foreach (var c in str)
            {
                if ("aeiou".Contains(c))
                {
                    result += 1;
                }
            }
            return result;
        }
        public static int ConsonantsAmount(this string str)
        {
            var result = 0;
            str = str.ToLower();
            foreach (var c in str)
            {
                if ("bcdfghjklmnpqrstvwxyz".Contains(c))
                {
                    result += 1;
                }
            }
            return result;
        }
        public static int SentencesAmount(this string str) 
        {
            var result = 0;
            foreach (var c in str)
            {
                if (".!?".Contains(c))
                {
                    result += 1;
                }
            }
            return result;
        }
    }
}
