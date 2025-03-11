using System.Collections.Specialized;

namespace _03___11_mar
{
    public class Rational
    {
        #region Fields
        private int numarator, numitor;
        #endregion

        #region Methods
        public Rational(): this(0, 1)
        {
            
        }
        public Rational(int numarator, int numitor)
        {
            if (numitor == 0)
                throw new ArgumentException("Numitorul este zero");
            this.numarator = numarator;
            this.numitor = numitor;
            this.Reduce();
        }

        private void Reduce()
        {
            int d = Util.Gcd(Math.Abs(numarator), Math.Abs(numitor));
            this.numarator /= d;
            this.numitor /= d;
        }

        public Rational Add(Rational other)
        {
            Rational r = new Rational();
            r.numarator = this.numarator * other.numitor + this.numitor * other.numarator;
            r.numitor = this.numitor * other.numitor;

            r.Reduce();

            return r;
        }

        public override string ToString()
        {
            return $"[{numarator} / {numitor}]";
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(numarator, numitor);
        }
        
        #endregion

        #region Properties
        public int Numarator => numarator;
        public int Numitor => numitor;
        #endregion
    }
}