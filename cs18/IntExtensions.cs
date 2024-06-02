
namespace cs18
{
    public static class IntExtensions
    {
        public static bool PairCheck(this int num)
        {
            return num % 2 == 0;
        }

        public static bool UnpairCheck(this int num)
        {
            return num % 2 != 0;
        }

        public static bool PrimeCheck(this int num) 
        {
            bool result = true;
            if (num > 1)
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
