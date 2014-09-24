using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters.NamedParameters
{
    public class FreqTimesCurSpecDensDivCurSquare:AbstractParameter<double>
    {
        public FreqTimesCurSpecDensDivCurSquare(IParameterHeader Header):base(Header)
        {
            
        }
        public FreqTimesCurSpecDensDivCurSquare(IParameterHeader Header,double Value):base(Header,Value)
        {
            
        }
        public FreqTimesCurSpecDensDivCurSquare(IParameterHeader Header, string Value)
            : base(Header, Value)
        {
            
        }
    }
}
