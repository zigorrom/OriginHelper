using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters.NamedParameters
{
    public class EquivalentNoiseSpectralDensity:AbstractParameter<double>
    {
        public EquivalentNoiseSpectralDensity(IParameterHeader Header):base(Header)
        {
            
        }
        public EquivalentNoiseSpectralDensity(IParameterHeader Header,double Value):base(Header,Value)
        {
            
        }
        public EquivalentNoiseSpectralDensity(IParameterHeader Header, string Value)
            : base(Header, Value)
        {
            
        }
    }
}
