using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters.NamedParameters
{
    public class AveragingPoints:AbstractParameter<uint>
    {
        public AveragingPoints(IParameterHeader Header):base(Header)
        {
            
        }
        public AveragingPoints(IParameterHeader Header,uint Value):base(Header,Value)
        {
            
        }
        public AveragingPoints(IParameterHeader Header, string Value)
            : base(Header, Value)
        {
            
        }
    }
}
