using Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    public class ParameterHeader<T>:IParameterHeader where T:IParameter
    {
        public ParameterHeader(string Name, string Comment, IUnit Unit)
        {
            this.Name = Name;
            this.Comment = Comment;
            this.Unit = Unit;
        }

        public string Name { get; private set; }


        public string Comment { get; private set; }

        public IUnit Unit{ get; private set; }

        public Type ParameterType{ get; private set; }

        public IParameterColumn CreateEmptyColumn()
        {
            return new ParameterColumn<T>();
        }

        public IParameter CreateParameter(string Value)
        {
            return (T)Activator.CreateInstance(typeof(T), new object[] { Clone(), Value });
        }

        public object Clone()
        {
            return new ParameterHeader<T>(Name, Comment, Unit);
        }
    }
}
