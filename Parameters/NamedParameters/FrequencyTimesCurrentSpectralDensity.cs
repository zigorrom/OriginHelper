﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters.NamedParameters
{
    class FrequencyTimesCurrentSpectralDensity
    {
        public Current(IParameterHeader Header):base(Header)
        {
            
        }
        public Current(IParameterHeader Header,double Value):base(Header,Value)
        {
            
        }
        public Current(IParameterHeader Header, string Value)
            : base(Header, Value)
        {
            
        }
    }
}
