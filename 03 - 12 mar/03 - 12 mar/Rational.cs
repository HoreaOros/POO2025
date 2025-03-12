using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace RationalNS
{
    public class Rational: IEquatable<Rational>, IComparable<Rational>
    {
        #region Fields
        private int numarator;
        private int numitor;
        #endregion


        #region Methods
        public Rational(): this(0, 1)
        {
            
        }

        public Rational(int numarator, int numitor)
        {
            this.numarator = numarator;
            this.numitor = numitor;
            this.numarator /= Utility.Util.Gcd(numarator, numitor);
            this.numitor /= Utility.Util.Gcd(numarator, numitor);
        }

        /// <summary>
        /// Aduna doua numere rationale
        /// </summary>
        private Rational Add(Rational other)
        {
            Rational r = new Rational();
            r.numarator = this.numarator * other.numitor + other.numarator * this.numitor;
            r.numitor = this.numitor * other.numitor;

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

        public bool Equals(Rational? other)
        {
            if (other is null)
                return false;

            // Optimization for a common success case.
            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }
            // If run-time types are not exactly the same, return false.
            if (this.GetType() != other.GetType())
            {
                return false;
            }

            return this.numarator * other.numitor == this.numitor * other.numarator;
        }

        public int CompareTo(Rational? other)
        {
             if (this.Equals(other))
                return 0;
            return this.numarator * other.numitor - this.numitor * other.numarator;

        }


        public static Rational operator+(Rational r1, Rational r2)
        {
            return r1.Add(r2);
        }
        public static bool operator ==(Rational r1, Rational r2)
        {
            return r1.Equals(r2);
        }
        public static bool operator !=(Rational r1, Rational r2)
        {
            return !(r1==r2);
        }

        #endregion

        #region Properties
        public int Numarator
        {
            get => numarator;
            set
            {
            }
        }

        public int Numitor
        {
            get => numitor;
            set
            {
            }
        }
        #endregion

        private class DescendingComparer : IComparer<Rational>
        {
            public int Compare(Rational x, Rational y)
            {
                return -x.CompareTo(y);
            }
        }
        public static IComparer<Rational> DescendingSort = new DescendingComparer();
    }
}