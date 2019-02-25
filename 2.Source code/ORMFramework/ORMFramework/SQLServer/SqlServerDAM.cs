using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlClient = System.Data.SqlClient;

namespace ORMFramework
{
    public class SqlServerDAM : DAMFramework
    {
        private SqlClient.SqlConnection sqlConnect;
        public SqlServerDAM(string datasource, string database, string username, string password)
        {
            this.connectionString = @"Data Source=" + datasource + "; Initial Catalog=" + database +
                ";Persist Security Info=True; MultipleActiveResultSets=true; User ID=" + username + "; Password=" + password;
            this.sqlConnect = new SqlClient.SqlConnection(this.connectionString);
        }
        public override void Open()
        {
            if (this.sqlConnect.State != System.Data.ConnectionState.Open)
                this.sqlConnect.Open();
        }
        public override void Close()
        {
            if (this.sqlConnect.State != System.Data.ConnectionState.Closed)
                this.sqlConnect.Close();
        }
        public override CanAddWhere<T> Select<T>()
        {
            return SqlSelectQuery<T>.Create(this.sqlConnect, this.connectionString);
        }
        public override int Insert<T>(T obj)
        {
            SqlInsertQuery<T> insertQuery = new SqlInsertQuery<T>(this.sqlConnect, this.connectionString, obj);
            return insertQuery.ExecuteNonQuery();
        }

        public override int Update<T>(T obj)
        {
            SqlUpdateQuery<T> updateQuery = new SqlUpdateQuery<T>(this.sqlConnect, this.connectionString, obj);
            return updateQuery.ExecuteNonQuery();
        }
        public override int Delete<T>(T obj)
        {
            SqlDeleteQuery<T> deleteQuery = new SqlDeleteQuery<T>(this.sqlConnect, this.connectionString, obj);
            return deleteQuery.ExecuteNonQuery();
        }
        public override List<T> ExecuteQuery<T>(string queryString)
        {
            SqlServerQuery query = new SqlServerQuery(this.sqlConnect, this.connectionString, queryString);
            return query.ExecuteQuery<T>();
        }
        public override int ExecuteNonQuery(string queryString)
        {
            SqlServerQuery query = new SqlServerQuery(this.sqlConnect, this.connectionString, queryString);
            return query.ExecuteNonQuery();
        }
    }
}
