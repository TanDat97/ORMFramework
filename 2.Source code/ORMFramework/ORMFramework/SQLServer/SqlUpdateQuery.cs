using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ORMFramework
{
    public class SqlUpdateQuery<T> : SqlServerQuery where T : new()
    {
        public SqlUpdateQuery(SqlConnection sqlConnect, string connectionString, T obj) : base(sqlConnect, connectionString)
        {
            Mapper mapper = new Mapper();
            string tableName = mapper.GetTableName<T>();
            List<PrimaryKeyAttribute> primaryKeys = mapper.GetPrimaryKeys<T>();
            Dictionary<ColumnAttribute, object> listColumnValues = mapper.GetColumnValues<T>(obj);
            if (listColumnValues != null && primaryKeys != null)
            {
                string setStr = string.Empty;
                string whereStr = string.Empty;
                foreach (ColumnAttribute column in listColumnValues.Keys)
                {
                    string format = "{0} = {1}, ";
                    if (column.Type == DataType.NCHAR || column.Type == DataType.NVARCHAR)
                        format = "{0} = N'{1}', ";
                    else if (column.Type == DataType.CHAR || column.Type == DataType.VARCHAR)
                        format = "{0} = '{1}', ";
                    setStr += string.Format(format, column.Name, listColumnValues[column]);
                }
                if (!string.IsNullOrEmpty(setStr))
                    setStr = setStr.Substring(0, setStr.Length - 2);
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
                        whereStr += string.Format(format, primaryKey.Name, listColumnValues[column]);
                    }
                }
                if (!string.IsNullOrEmpty(whereStr))
                {
                    whereStr = whereStr.Substring(0, whereStr.Length - 2);
                    this.query = string.Format("UPDATE {0} SET {1} WHERE {2}", tableName, setStr, whereStr);
                }
            }
        }
    }
}
