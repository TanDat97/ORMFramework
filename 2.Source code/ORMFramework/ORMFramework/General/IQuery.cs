using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMFramework
{
    public interface IQuery
    {
        List<T> ExecuteQuery<T>() where T : new();
        int ExecuteNonQuery();
    }

    public interface CanAddWhere<T> where T : new()
    {
        CanAddHavingOrQuery<T> Where(string condition);
        CanAddHavingOrQuery<T> AllRow();
    }

    public interface CanAddHavingOrQuery<T> where T : new()
    {
        CanAddGroupBy<T> Having(string condition);
        List<T> Query();
    }

    public interface CanAddGroupBy<T> where T : new()
    {
        CanQuery<T> GroupBy(string columnNames);
    }

    public interface CanQuery<T> where T : new()
    {
        List<T> Query();
    }
}
