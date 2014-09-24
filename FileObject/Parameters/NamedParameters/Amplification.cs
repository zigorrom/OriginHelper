using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters.NamedParameters
{
    public class Amplification:AbstractParameter<short>
    {
        public Amplification(IParameterHeader Header):base(Header)
        {
            
        }
        public Amplification(IParameterHeader Header,short Value):base(Header,Value)
        {
            
        }
        public Amplification(IParameterHeader Header, string Value)
            : base(Header, Value)
        {
            
        }
    }
}
