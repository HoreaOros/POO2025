using System.Text;

internal class Complex
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

    public Complex Add(Complex c2)
    {
        Complex c = new Complex();
        c.re = this.re + c2.re;
        c.im = this.im + c2.im;

        return c;
    }
    #endregion

    #region Properties
    #endregion
}