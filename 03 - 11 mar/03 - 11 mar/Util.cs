using System.Net.Http.Headers;

namespace _03___11_mar
{
    internal class Util
    {
        internal static int Gcd(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return Gcd(b, a % b);
        }
    }
}