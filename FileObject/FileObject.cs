using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileObject
{
    public class FileObject:StreamReader,IParameterContainer
    {
        private Dictionary<IParameterHeader, IParameterColumn> m_ParameterColumns;
        private FileReaderConfig m_config;
        private Dictionary<IParameterHeader, int> m_ParametersContains;
        public FileObject(string Path):base(Path)
        {

        }
        //public FileObject(MemoryStream Stream)
        //    : base(Stream)
        //{ }
        public FileObject(Stream Stream):base(Stream)
        {
 
        }
        private void InitializeParameters()
        {
            m_ParameterColumns = new Dictionary<IParameterHeader, IParameterColumn>();

        }
    }
}
