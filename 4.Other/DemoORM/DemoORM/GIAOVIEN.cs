using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORMFramework;

namespace DemoORM
{
    [TableAttribute("GIAOVIEN")]
    public class GIAOVIEN
    {
        [PrimaryKeyAttribute("MAGV", false)]
        [ColumnAttribute("MAGV", DataType.CHAR)]
        public string MAGV { get; set; }

        [ColumnAttribute("HOTEN", DataType.NVARCHAR)]
        public string HOTEN { get; set; }

        [ColumnAttribute("PHAI", DataType.NCHAR)]
        public string PHAI { get; set; }

        [ColumnAttribute("DIACHI", DataType.NVARCHAR)]
        public string DIACHI { get; set; }

        [ColumnAttribute("MABM", DataType.NCHAR)]
        public string MABM { get; set; }
    }
}
