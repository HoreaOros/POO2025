using System.Collections.Specialized;

namespace _03___11_mar
{
    public class Rational: IEquatable<Rational>, IComparable<Rational>
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
        public override bool Equals(object? obj)
        {
            return Equals(obj as Rational);
        }

        public bool Equals(Rational? p)
        {
            if (p is null)
            {
                return false;
            }

            // Optimization for a common success case.
            if (Object.ReferenceEquals(this, p))
            {
                return true;
            }

            // If run-time types are not exactly the same, return false.
            if (this.GetType() != p.GetType())
            {
                return false;
            }

            // Return true if the fields match.
            // Note that the base class is not invoked because it is
            // System.Object, which defines Equals as reference equality.
            return this.numarator * p.numitor == this.numitor * p.numarator;
        }

        public int CompareTo(Rational? other)
        {
            // If other is not a valid object reference, this instance is greater.
            if (other == null) 
                return 1;

            if (this.Equals(other))
                return 0;
            return this.numarator * other.numitor - this.numitor * other.numarator;   

        }
        #endregion

        #region Properties
        public int Numarator => numarator;
        public int Numitor => numitor;
        #endregion

        #region Operator overloads
        public static Rational operator+(Rational lhs, Rational rhs) 
        {
            return lhs.Add(rhs);
        }

        public static bool operator ==(Rational lhs, Rational rhs)
        {
            if (lhs is null)
            {
                if (rhs is null)
                {
                    return true;
                }

                // Only the left side is null.
                return false;
            }
            // Equals handles case of null on right side.
            return lhs.Equals(rhs);
        }

        // Operatorii relational
        public static bool operator <(Rational lhs, Rational rhs)
        {
            return lhs.CompareTo(rhs) < 0;  
        }
        public static bool operator >(Rational lhs, Rational rhs)
        {
            return lhs.CompareTo(rhs) > 0;
        }
        public static bool operator <=(Rational lhs, Rational rhs)
        {
            return lhs.CompareTo(rhs) <= 0;
        }
        public static bool operator >=(Rational lhs, Rational rhs)
        {
            return lhs.CompareTo(rhs) >= 0;
        }
        public static bool operator !=(Rational lhs, Rational rhs) => !(lhs == rhs);
        #endregion

        // SortDescending
        private class SortDescending : IComparer<Rational>
        {
            public int Compare(Rational? x, Rational? y)
            {
                return -x.CompareTo(y);
            }
        }
        public static IComparer<Rational> DescendingSort = new SortDescending();
    }
}