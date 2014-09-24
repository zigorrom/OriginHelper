using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters.NamedParameters
{
    public class Temperature:AbstractParameter<double>
    {
        public Temperature(IParameterHeader Header):base(Header)
        {
            
        }
        public Temperature(IParameterHeader Header,double Value):base(Header,Value)
        {
            
        }
        public Temperature(IParameterHeader Header, string Value)
            : base(Header, Value)
        {
            
        }
    }
}
