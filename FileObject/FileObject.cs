using Parameters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileObject
{
    public class FileObject : StreamReader, IParameterContainer
    {
        private Dictionary<IParameterHeader, IParameterColumn> m_ParameterColumns;
        private FileReaderConfig m_config;
        private Dictionary<IParameterHeader, int> m_ContainingParameters;

        #region Constructors

        public FileObject(string Path, FileReaderConfig Config, Dictionary<IParameterHeader, int> ContainingParameters)
            : base(Path)
        {
            Initialize(Config, ContainingParameters);
        }

        public FileObject(Stream Stream, FileReaderConfig Config, Dictionary<IParameterHeader, int> ContainingParameters)
            : base(Stream)
        {
            Initialize(Config, ContainingParameters);
        }
        #endregion

        #region Initialization

        private void Initialize(FileReaderConfig Config, Dictionary<IParameterHeader, int> ContainingParameters)
        {
            m_config = Config;
            m_ContainingParameters = ContainingParameters;
            InitializeParameters();
        }
        private void InitializeParameters()
        {
            m_ParameterColumns = new Dictionary<IParameterHeader, IParameterColumn>();
            foreach (var param in m_ContainingParameters)
            {
                m_ParameterColumns.Add(param.Key, param.Key.CreateEmptyColumn());
            }
            int count = 0;
            while (!this.EndOfStream)
            {
                if (count++ < m_config.FirstDataLine)
                    continue;
                var LineItems = ReadLine().Split(m_config.SplitString.ToCharArray());
                try
                {
                    foreach (var param in m_ContainingParameters)
                    {
                        m_ParameterColumns[param.Key].AddParameter(LineItems[param.Value]);
                    }
                }
                catch (Exception e)
                {
                    throw;
                }
            }
        }
        #endregion


    }
}
