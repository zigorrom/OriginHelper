using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileObject;

namespace Parameters.NamedParameters
{
    public class FileParam:AbstractParameter<FileObject.FileObject>
    {
        public FileParam(IParameterHeader Header):base(Header)
        {
            
        }
        public FileParam(IParameterHeader Header, FileObject.FileObject Value)
            : base(Header, Value)
        {
            
        }
        public FileParam(IParameterHeader Header, string Value)
            : base(Header, Value)
        {
            
        }
    }
}
