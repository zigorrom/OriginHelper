using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters.NamedParameters
{
    public class CurrentSpectralDensity:AbstractParameter<double>
    {
        public CurrentSpectralDensity(IParameterHeader Header):base(Header)
        {
            
        }
        public CurrentSpectralDensity(IParameterHeader Header,double Value):base(Header,Value)
        {
            
        }
        public CurrentSpectralDensity(IParameterHeader Header, string Value)
            : base(Header, Value)
        {
            
        }
    }
}
