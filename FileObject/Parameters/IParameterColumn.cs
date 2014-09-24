using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parameters
{
    public interface IParameterColumn:IList<IParameter>
    {
        void AddParameter(string p);
        void AddParameter(IParameter p);
    }
}
