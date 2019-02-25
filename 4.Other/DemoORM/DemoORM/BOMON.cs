using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORMFramework;

namespace DemoORM
{
    [TableAttribute("BOMON")]
    public class BOMON
    {
        [PrimaryKeyAttribute("MABM", false)]
        [ColumnAttribute("MABM", DataType.NCHAR)]
        public string MABM { get; set; }

        [ColumnAttribute("TENBM", DataType.NVARCHAR)]
        public string TENBM { get; set; }

        [ColumnAttribute("DIENTHOAI", DataType.CHAR)]
        public string DIENTHOAI { get; set; }

        [ColumnAttribute("TRUONGBM", DataType.CHAR)]
        public string TRUONGBM { get; set; }
    }
}
