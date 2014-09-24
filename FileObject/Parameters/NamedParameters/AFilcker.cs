using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters.NamedParameters
{
    public class AFlicker:AbstractParameter<double>
    {
        public AFlicker(IParameterHeader Header):base(Header)
        {
            
        }
        public AFlicker(IParameterHeader Header,double Value):base(Header,Value)
        {
            
        }
        public AFlicker(IParameterHeader Header, string Value):base(Header,Value)
        {
            
        }
        
    }
}
