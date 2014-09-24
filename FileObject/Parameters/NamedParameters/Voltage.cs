using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters.NamedParameters
{
    public class Voltage:AbstractParameter<double>
    {
        public Voltage(IParameterHeader Header):base(Header)
        {
            
        }
        public Voltage(IParameterHeader Header,double Value):base(Header,Value)
        {
            
        }
        public Voltage(IParameterHeader Header, string Value)
            : base(Header, Value)
        {
            
        }
    }
}
