using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters.NamedParameters
{
    public class Frequency:AbstractParameter<double>
    {
        public Frequency(IParameterHeader Header):base(Header)
        {
            
        }
        public Frequency(IParameterHeader Header,double Value):base(Header,Value)
        {
            
        }
        public Frequency(IParameterHeader Header, string Value)
            : base(Header, Value)
        {
            
        }
    }
}
