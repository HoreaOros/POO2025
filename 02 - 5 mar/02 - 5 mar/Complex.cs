using System.Text;

internal class Complex: IEquatable<Complex>
{
    #region Fields
    private double re;
    private double im;
    #endregion

    #region Constructors
    public Complex(double re = 0, double im = 0)
    {
        this.re = re;
        this.im = im;
    }

    //public Complex(): this(0, 0)
    //{
        
    //}
    #endregion

    #region Methods
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("(");
        sb.Append(re);
        sb.Append(", ");
        sb.Append(im);
        sb.Append(")");
        return sb.ToString();
    }
    public override bool Equals(object? obj)
    {
        return this.Equals(obj as Complex);
    }
    private Complex Add(Complex c2)
    {
        Complex c = new Complex();
        c.re = this.re + c2.re;
        c.im = this.im + c2.im;

        return c;
    }

    public Complex Multiply(Complex c2)
    {
        Complex r = new Complex();

        r.re = this.re * c2.re - this.im * c2.im;
        r.im = this.re * c2.im + this.im * c2.re;

        return r;
    }

    public bool Equals(Complex? other)
    {
        if (other is null)
        {
            return false;
        }
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

        return this.re == other.re && this.im == other.im;
    }
    public override int GetHashCode()
    {
        return (re, im).GetHashCode();
    }
    #endregion

    #region Properties
    #endregion

    #region Operator overloads
    public static Complex operator +(Complex a, Complex b)
    {
        return a.Add(b);
    }
    public static bool operator ==(Complex lhs, Complex rhs)
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
    public static bool operator != (Complex lhs, Complex rhs)
    {
        return !(lhs == rhs);
    }
    #endregion

}