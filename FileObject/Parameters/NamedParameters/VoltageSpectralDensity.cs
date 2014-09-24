using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters.NamedParameters
{
    public class VoltageSpectralDensity:AbstractParameter<double>
    {
        public VoltageSpectralDensity(IParameterHeader Header):base(Header)
        {
            
        }
        public VoltageSpectralDensity(IParameterHeader Header,double Value):base(Header,Value)
        {
            
        }
        public VoltageSpectralDensity(IParameterHeader Header, string Value)
            : base(Header, Value)
        {
            
        }
    }
}
