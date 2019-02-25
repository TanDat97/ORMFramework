using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;

namespace ORMFramework
{
    public class Mapper
    {
        protected object GetFirstEqual(object[] attributes, Type type)
        {
            foreach (var a in attributes)
            {
                if (a.GetType() == type)
                    return a;
            }
            return null;
        }
        public T MapData<T>(DataRow dr) where T : new()
        {
            T obj = new T();
            var properties = typeof(T).GetProperties();
            foreach (var property in properties)
            {
                var attributes = property.GetCustomAttributes(false);
                var columnMapping = GetFirstEqual(attributes, typeof(ColumnAttribute));
                if (columnMapping != null)
                {
                    var column = columnMapping as ColumnAttribute;
                    property.SetValue(obj, dr[column.Name]);
                }
            }
            return obj;
        }
        public string GetTableName<T>() where T : new()
        {
            var tableAttributes = typeof(T).GetCustomAttributes(typeof(TableAttribute), true);
            var tableAttribute = GetFirstEqual(tableAttributes, typeof(TableAttribute)) as TableAttribute;
            if (tableAttribute != null)
                return tableAttribute.Name;
            return string.Empty;
        }
        public List<PrimaryKeyAttribute> GetPrimaryKeys<T>() where T : new()
        {
            List<PrimaryKeyAttribute> primaryKeys = new List<PrimaryKeyAttribute>();
            var properties = typeof(T).GetProperties();
            foreach (var property in properties)
            {
                var attributes = property.GetCustomAttributes(false);
                var primaryKeyAttribute = GetFirstEqual(attributes, typeof(PrimaryKeyAttribute));
                if (primaryKeyAttribute != null)
                    primaryKeys.Add(primaryKeyAttribute as PrimaryKeyAttribute);
            }
            if (primaryKeys.Count > 0)
                return primaryKeys;
            else
                return null;
        }
        public List<ColumnAttribute> GetColumns<T>() where T : new()
        {
            List<ColumnAttribute> columnAttributes = new List<ColumnAttribute>();
            var properties = typeof(T).GetProperties();
            foreach (var property in properties)
            {
                var attributes = property.GetCustomAttributes(false);
                var column = GetFirstEqual(attributes, typeof(ColumnAttribute));
                if (column != null)
                {
                    columnAttributes.Add((ColumnAttribute)column);
                }
            }
            if (columnAttributes.Count > 0)
                return columnAttributes;
            else
                return null;
        }
        public Dictionary<ColumnAttribute, object> GetColumnValues<T>(T obj)
        {
            Dictionary<ColumnAttribute, object> listColumnValues = new Dictionary<ColumnAttribute, object>();
            var properties = typeof(T).GetProperties();
            foreach (var property in properties)
            {
                var attributes = property.GetCustomAttributes(false);
                var column = GetFirstEqual(attributes, typeof(ColumnAttribute));
                if (column != null)
                {
                    listColumnValues.Add((ColumnAttribute)column, property.GetValue(obj, null));
                }
            }
            if (listColumnValues.Count > 0)
                return listColumnValues;
            else
                return null;
        }
        public ColumnAttribute FindColumn(string name, Dictionary<ColumnAttribute, object> listColumn)
        {
            foreach (ColumnAttribute column in listColumn.Keys)
                if (column.Name == name)
                    return column;
            return null;
        }

        public ColumnAttribute FindColumn(string name, List<ColumnAttribute> listColumn)
        {
            foreach (ColumnAttribute column in listColumn)
                if (column.Name == name)
                    return column;
            return null;
        }
    }
}
