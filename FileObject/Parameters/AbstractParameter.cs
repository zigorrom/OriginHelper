using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    public abstract class AbstractParameter<T>:IParameter
    {
        public IParameterHeader Header { get; private set; }
        public T Value { get; private set; }
        public AbstractParameter(IParameterHeader Header)
        {
            this.Header = Header;
            this.Value = default(T);
        }
        public AbstractParameter(IParameterHeader Header,T Value)
        {
            this.Header = Header;
            this.Value = Value;
        }
        public AbstractParameter(IParameterHeader Header, string Value)
        {
            this.Header = Header;
            this.Value = FromString(Value);
        }

        protected T FromString(string Value)
        {
            return (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFromString(Value);
        }
                
        object IParameter.Value
        {
            get { return Value; }
        }
    }
}
