using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ModularCounter: Counter
{
    #region Fields
    private int _modulus;
    #endregion

    #region Properties
    public int Modulus => _modulus;
    #endregion

    #region Constructors
    public ModularCounter(int modulus): this(modulus, 0)
    {
            
    }

    public ModularCounter(int modulus, int count) : this(modulus, count, 1)
    {

    }


    /// <summary>
    /// Constructs a ModularCounter with the specified modulus, count, and step.
    /// </summary>
    /// <param name="modulus">Modulus</param>
    /// <param name="count">Initial value of counter</param>
    /// <param name="step">Step used by the counter</param>
    public ModularCounter(int modulus, int count, int step) : base(count, step)
    {
        _modulus = modulus;
    }
    #endregion

    #region Methods
    public override void Tick()
    {
        base.Tick();
        if (Count >= _modulus)
            _count = _count % Modulus;
    }

    public override string ToString()
    {
        return $"[Count: {Count}, Modulus: {Modulus}, Step: {Step}]";
    }
    #endregion
}
