using System.Text;

internal class Complex
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

    public Complex Add(Complex c2)
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
    #endregion

    #region Properties
    public double Modul
    {
        get
        {
            return Math.Abs(Math.Pow(re, 2) + Math.Pow(im, 2));
        }
    }
    #endregion
}