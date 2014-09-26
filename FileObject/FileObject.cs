using Parameters;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileObjectProject
{
    public class FileObject : StreamReader, IParameterContainer 
    {
        public Dictionary<IParameterHeader, IParameterColumn> ParameterColumns { get; protected set; }
        public  FileReaderConfig config { get; protected set; }
        public Dictionary<IParameterHeader, int> ContainingParameters { get; protected set; }

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
            this.config = Config;
            this.ContainingParameters = ContainingParameters;
            InitializeParameters();
        }
        private void InitializeParameters()
        {
            ParameterColumns = new Dictionary<IParameterHeader, IParameterColumn>();
            foreach (var param in ContainingParameters)
            {
                ParameterColumns.Add(param.Key, param.Key.CreateEmptyColumn());
            }
          
            for (int i = 0; i < config.FirstDataLine; i++)
            {
                var temp = ReadLine();
            }
            while (!this.EndOfStream)
            {
                var LineItems = ReadLine().Split(config.SplitString.ToCharArray());
                try
                {
                    foreach (var param in ContainingParameters)
                    {
                        var Parameter = param.Key.CreateParameter(LineItems[param.Value]);
                        ParameterColumns[param.Key].AddParameter(Parameter);
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
