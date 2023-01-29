using MusteriTakip.Common.Extensions;
using MusteriTakip.Common.Generic;
using MusteriTakip.Common.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MusteriTakip.Common.Helpers
{
    /// <summary>
    /// Author: Can DOĞU
    /// </summary>
    public class SqlHelper : Singleton<SqlHelper>
    {
        /// <summary>
        /// Fetch generic data from database and return list of items (table name constant class scope)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sqlCommand"></param>
        /// <returns></returns>
        public async Task<(List<T>, string)> GetItems<T>(Func<T, bool> filter = null)
        {
            try
            {
                var list = new List<T>();
                var t = Activator.CreateInstance<T>();

                var classScope = t.GetType().GetField(Constants.Scope).GetRawConstantValue().ToString();

                var sqlCommand = $"select * from {classScope} with (nolock)";

                if (Statics.SqlSetting.Item1 == null) return await Task.FromResult((new List<T>(), Statics.SqlSetting.Item2));

                if (Statics.SqlSetting.Item1.ConnectionString.IsNullOrEmpty()) return await Task.FromResult((new List<T>(), Constants.DbConnectionStringIncorrect));

                using (var sqlCon = new SqlConnection(Statics.SqlSetting.Item1.ConnectionString))
                using (var sqlCmd = new SqlCommand(sqlCommand, sqlCon))
                {
                    if (sqlCon.State == ConnectionState.Closed)
                        sqlCon.Open();

                    using (var reader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        if (reader.HasRows)
                        {
                            if (filter != null)
                            {
                                list = reader.ToMapList<T>().Item1.Where(filter).ToList();
                            }
                            else
                            {
                                list = reader.ToMapList<T>().Item1.ToList();
                            }
                        }
                    }
                }

                return await Task.FromResult((list, string.Empty));
            }
            catch (Exception ex)
            {
                return await Task.FromResult((new List<T>(), ex.ToString()));
            }
        }
    }
}
