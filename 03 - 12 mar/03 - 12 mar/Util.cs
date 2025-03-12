
namespace Utility
{
    public class Util
    {
        public static int Gcd(int a, int b)
        {
            return b == 0 ? a : Gcd(b, a % b);
        }
    }
}