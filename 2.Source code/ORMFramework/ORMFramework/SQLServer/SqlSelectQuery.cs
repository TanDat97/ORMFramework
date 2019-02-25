using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ORMFramework
{
    class SqlSelectQuery<T> : SqlServerQuery, CanAddWhere<T>, CanAddHavingOrQuery<T>, CanAddGroupBy<T>, CanQuery<T> where T : new()
    {
        private SqlSelectQuery(SqlConnection sqlConnect, string connectionString) : base(sqlConnect, connectionString)
        {
            Mapper mapper = new Mapper();
            this.query += "SELECT";
            foreach (ColumnAttribute column in mapper.GetColumns<T>())
                this.query = string.Format("{0} {1},", this.query, column.Name);
            this.query = this.query.Substring(0, this.query.Length - 1);
            this.query = string.Format("{0} FROM {1}", this.query, mapper.GetTableName<T>());
        }
        public static CanAddWhere<T> Create(SqlConnection sqlConnect, string connectionString)
        {
            return new SqlSelectQuery<T>(sqlConnect, connectionString);
        }
        public CanAddHavingOrQuery<T> Where(string condition)
        {
            this.query = string.Format("{0} WHERE {1}", this.query, condition);
            return this;
        }
        public CanAddHavingOrQuery<T> AllRow()
        {
            return this;
        }
        public CanAddGroupBy<T> Having(string condition)
        {
            this.query = string.Format("{0} HAVING {1}", this.query, condition);
            return this;
        }
        public CanQuery<T> GroupBy(string columnNames)
        {
            this.query = string.Format("{0} GROUP BY {1}", this.query, columnNames);
            return this;
        }
        public List<T> Query()
        {
            return ExecuteQuery<T>();
        }
    }
}
