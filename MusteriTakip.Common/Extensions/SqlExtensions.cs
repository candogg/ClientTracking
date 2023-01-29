using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace MusteriTakip.Common.Extensions
{
    /// <summary>
    /// Author: Can DOĞU
    /// </summary>
    public static class SqlExtensions
    {
        /// <summary>
        /// Maps a datarecord to a given generic type for single row
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataReader"></param>
        /// <returns></returns>
        public static T ToMapSingle<T>(this IDataRecord dataReader)
        {
            try
            {
                var t = Activator.CreateInstance<T>();
                var props = t.GetType().GetProperties();

                var t2 = Activator.CreateInstance<T>();

                foreach (var prop in props)
                {
                    if (!Enumerable.Range(0, dataReader.FieldCount).Select(i => dataReader.GetName(i)).ToList().Any(x => x == prop.Name)
                        || dataReader[prop.Name] == DBNull.Value) continue;

                    prop.SetValue(t2, dataReader[prop.Name]);
                }

                return t2;
            }
            catch
            { }

            return default;
        }

        /// <summary>
        /// Maps data from datareader to given generic type and returns as list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataReader"></param>
        /// <returns></returns>
        public static (List<T>, string) ToMapList<T>(this SqlDataReader dataReader)
        {
            try
            {
                var list = new List<T>();

                var t = Activator.CreateInstance<T>();
                var props = t.GetType().GetProperties();

                while (dataReader.Read())
                {
                    var item = dataReader.ToMapSingle<T>();

                    if (Equals(item, default(T))) continue;

                    list.Add(item);
                }

                return (list, string.Empty);
            }
            catch (Exception ex)
            {
                return (new List<T>(), ex.ToString());
            }
        }
    }
}
