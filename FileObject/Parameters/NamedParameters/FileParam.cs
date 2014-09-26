using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileObjectProject;

namespace Parameters.NamedParameters
{
    public class FileParam:AbstractParameter<FileObjectProject.FileObject>
    {
        public FileParam(IParameterHeader Header):base(Header)
        {
            
        }
        public FileParam(IParameterHeader Header, FileObjectProject.FileObject Value)
            : base(Header, Value)
        {
            
        }
        public FileParam(IParameterHeader Header, string Value)
            : base(Header, Value)
        {
            
        }
    }
}
