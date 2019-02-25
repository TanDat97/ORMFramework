using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMFramework
{
    public abstract class DAMFramework
    {
        protected string connectionString { get; set; }
        public abstract void Open();
        public abstract void Close();
        public abstract CanAddWhere<T> Select<T>() where T : new();
        public abstract int Insert<T>(T obj) where T : new();
        public abstract int Update<T>(T obj) where T : new();
        public abstract int Delete<T>(T obj) where T : new();
        public abstract List<T> ExecuteQuery<T>(string query) where T : new();
        public abstract int ExecuteNonQuery(string query);
    }
}
