using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters.NamedParameters
{
    public class Resistance:AbstractParameter<double>
    {
        public Resistance(IParameterHeader Header):base(Header)
        {
            
        }
        public Resistance(IParameterHeader Header,double Value):base(Header,Value)
        {
            
        }
        public Resistance(IParameterHeader Header, string Value)
            : base(Header, Value)
        {
            
        }
    }
}
