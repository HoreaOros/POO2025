using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace RationalNS
{
    public class Rational
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
        public Rational Add(Rational other)
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
            return $"[{numarator} / {numitor}]";
        }
        #endregion

        #region Properties
        public int Numarator
        {
            get => default;
            set
            {
            }
        }

        public int Numitor
        {
            get => default;
            set
            {
            }
        }
        #endregion


    }
}