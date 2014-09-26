using Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    public class ParameterColumn<T>:List<IParameter>,IParameterColumn where T:IParameter
    {

        public void AddParameter(IParameter p)
        {
            Add(p);    
        }
        
        
    }
}
