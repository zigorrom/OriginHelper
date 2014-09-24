using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parameters
{
    public interface IParameterHeader:ICloneable
    {
        string Name { get; }
        string Comment { get; }
        IUnit Unit { get; }
        Type ParameterType { get; }
        IParameterColumn CreateEmptyColumn();
        IParameter CreateParameter(string Value);
    }
}
