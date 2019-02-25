using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ORMFramework
{
    public class SqlDeleteQuery<T> : SqlServerQuery where T : new()
    {
        public SqlDeleteQuery(SqlConnection sqlConnect, string connectionString, T obj) : base(sqlConnect, connectionString)
        {
            Mapper mapper = new Mapper();
            string tableName = mapper.GetTableName<T>();
            List<PrimaryKeyAttribute> primaryKeys = mapper.GetPrimaryKeys<T>();
            Dictionary<ColumnAttribute, object> listColumnValues = mapper.GetColumnValues<T>(obj);

            string deleteStr = string.Empty;
            foreach (PrimaryKeyAttribute primaryKey in primaryKeys)
            {
                ColumnAttribute column = mapper.FindColumn(primaryKey.Name, listColumnValues);
                if (column != null)
                {
                    string format = "{0} = {1}, ";
                    if (column.Type == DataType.NCHAR || column.Type == DataType.NVARCHAR)
                        format = "{0} = N'{1}', ";
                    else if (column.Type == DataType.CHAR || column.Type == DataType.VARCHAR)
                        format = "{0} = '{1}', ";

                    deleteStr += string.Format(format, primaryKey.Name, listColumnValues[column]);
                }
            }
            if (!string.IsNullOrEmpty(deleteStr))
            {
                deleteStr = deleteStr.Substring(0, deleteStr.Length - 2);
                this.query = string.Format("DELETE {0} WHERE {1}", tableName, deleteStr);
            }
        }
    }
}
