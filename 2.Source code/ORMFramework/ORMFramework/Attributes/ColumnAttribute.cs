using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMFramework
{
    public class ColumnAttribute : Attribute
    {
        public string Name { get; private set; }
        public DataType Type { get; private set; }
        public ColumnAttribute(string name, DataType type)
        {
            Type = type;
            Name = name;
        }
    }
}
