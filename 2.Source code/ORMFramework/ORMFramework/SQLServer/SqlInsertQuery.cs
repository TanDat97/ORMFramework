using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ORMFramework
{
    public class SqlInsertQuery<T> : SqlServerQuery where T : new()
    {
        public SqlInsertQuery(SqlConnection sqlConnect, string connectionString, T obj) : base(sqlConnect, connectionString)
        {
            Mapper mapper = new Mapper();
            string tableName = mapper.GetTableName<T>();
            List<PrimaryKeyAttribute> primaryKeys = mapper.GetPrimaryKeys<T>();
            Dictionary<ColumnAttribute, object> listColumnNameValues = mapper.GetColumnValues<T>(obj);
            if (listColumnNameValues.Count != 0)
            {
                string columnStr = string.Empty;
                string valueStr = string.Empty;
                foreach (ColumnAttribute column in listColumnNameValues.Keys)
                {
                    bool isAutoID = false;
                    foreach (PrimaryKeyAttribute primaryKey in primaryKeys)
                    {
                        if (column.Name == primaryKey.Name && primaryKey.AutoID)
                        {
                            isAutoID = true;
                            break;
                        }
                    }
                    if (!isAutoID)
                    {
                        string format = "{0}, ";
                        if (column.Type == DataType.NCHAR || column.Type == DataType.NVARCHAR)
                            format = "N'{0}', ";
                        else if (column.Type == DataType.CHAR || column.Type == DataType.VARCHAR)
                            format = "'{0}', ";
                        columnStr += string.Format("{0}, ", column.Name);
                        valueStr += string.Format(format, listColumnNameValues[column]);
                    }
                }
                if (!string.IsNullOrEmpty(columnStr) && !string.IsNullOrEmpty(valueStr))
                {
                    columnStr = columnStr.Substring(0, columnStr.Length - 2);
                    valueStr = valueStr.Substring(0, valueStr.Length - 2);
                    this.query = string.Format("INSERT INTO {0} ({1}) VALUES ({2})", tableName, columnStr, valueStr);
                }
            }
        }
    }
}
