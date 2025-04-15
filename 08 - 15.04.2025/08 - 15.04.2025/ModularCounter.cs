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
    #endregion
}
