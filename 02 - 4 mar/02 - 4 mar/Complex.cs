using System;
using System.Text;

internal class Complex: IEquatable<Complex>
{
    #region Fields
    private double re;
    private double im;
    #endregion

    #region Constructors
    //public Complex() : this(0, 0)
    //{

    //}
    public Complex(double re = 0, double im = 0)
    {
        this.re = re;
        this.im = im;
    }
    #endregion

    #region Methods
    public override bool Equals(object? obj)
    {
        return this.Equals(obj as Complex);
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append('(');
        sb.Append(re);
        if (im < 0)
            sb.Append('-');
        else
            sb.Append('+');
        sb.Append(Math.Abs(im));
        sb.Append('i');
        sb.Append(')');

        return sb.ToString();
    }

    private Complex Add(Complex c2)
    {
        return new Complex(re + c2.re, im + c2.im);
    }
    public Complex Subtract(Complex c2)
    {
        return new Complex(re - c2.re, im - c2.im);
    }
    public Complex Multiply(Complex c2)
    {
        Complex m = new Complex();
        m.re = re * c2.re - im * c2.im;
        m.im = re * c2.im + im * c2.re;
        return m;

        //return new Complex(re * c2.re - im * c2.im, re * c2.im + im * c2.re);
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

        // If run - time types are not exactly the same, return false.
        if (this.GetType() != other.GetType())
        {
            return false;
        }
        // Return true if the fields match.
        // Note that the base class is not invoked because it is
        // System.Object, which defines Equals as reference equality.
        return (this.re == other.re) && (this.im == other.im);
    }
    #endregion

    #region Properties
    public double Modul
    {
        get
        {
            return Math.Sqrt(Math.Pow(re, 2) + Math.Pow(im, 2));
        }
    }
    public double Argument => Math.Atan2(im, re);
    #endregion

    #region Operator overloads
    public static Complex operator +(Complex a, Complex b)
    {
        return a.Add(b);
    }
    // TODO: 
    // supraincarcarea operatorilor: -, *.


    #endregion
}