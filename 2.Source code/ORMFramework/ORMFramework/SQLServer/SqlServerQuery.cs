using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ORMFramework
{
    public class SqlServerQuery : IQuery
    {
        protected string connectionString;
        protected SqlCommand cmd;
        protected string query;
        public SqlServerQuery(SqlConnection sqlConnect, string connectionString)
        {
            this.connectionString = connectionString;
            this.cmd = new SqlCommand();
            this.cmd.Connection = sqlConnect;
            this.cmd.CommandType = CommandType.Text;
        }
        public SqlServerQuery(SqlConnection sqlConnect, string connectionString, string query)
        {
            this.connectionString = connectionString;
            this.cmd = new SqlCommand();
            this.cmd.Connection = sqlConnect;
            this.cmd.CommandType = CommandType.Text;
            this.query = query;
        }

        public List<T> ExecuteQuery<T>() where T : new()
        {
            this.cmd.CommandText = this.query;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(this.cmd);
            adapter.Fill(dt);
            List<T> res = new List<T>();
            Mapper mapper = new Mapper();
            foreach (DataRow dr in dt.Rows)
                res.Add(mapper.MapData<T>(dr));
            return res;
        }

        public int ExecuteNonQuery()
        {
            this.cmd.CommandText = this.query;
            return this.cmd.ExecuteNonQuery();
        }
    }
}
