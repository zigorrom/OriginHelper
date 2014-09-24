using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters.NamedParameters
{
    public class AlphaFlicker:AbstractParameter<int>
    {
         public AlphaFlicker(IParameterHeader Header):base(Header)
        {
            
        }
        public AlphaFlicker(IParameterHeader Header,int Value):base(Header,Value)
        {
            
        }
        public AlphaFlicker(IParameterHeader Header, string Value)
            : base(Header, Value)
        {
            
        }

        
    }
}
