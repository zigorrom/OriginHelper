using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters.NamedParameters
{
    public class FrequencyTimesCurrentSpectralDensity:AbstractParameter<double>
    {
        public FrequencyTimesCurrentSpectralDensity(IParameterHeader Header):base(Header)
        {
            
        }
        public FrequencyTimesCurrentSpectralDensity(IParameterHeader Header,double Value):base(Header,Value)
        {
            
        }
        public FrequencyTimesCurrentSpectralDensity(IParameterHeader Header, string Value)
            : base(Header, Value)
        {
            
        }
    }
}
