using MusteriTakip.Common.Extensions;
using MusteriTakip.Common.Generic;
using MusteriTakip.Common.Items;
using MusteriTakip.Common.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace MusteriTakip.Common.Helpers
{
    /// <summary>
    /// Author: Can DOĞU
    /// </summary>
    public class SqlHelper : Singleton<SqlHelper>
    {
        /// <summary>
        /// Fetch generic data from database and return list of items
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sqlCommand"></param>
        /// <returns></returns>
        public async Task<(List<T>, string)> GetItems<T>(string sqlCommand)
        {
            try
            {
                var list = new List<T>();

                var sqlSetting = FileHelper.Instance.ReadSettingSection<DbConnectionSettingsItem>();

                if (sqlSetting.Item1 == null) return await Task.FromResult((new List<T>(), sqlSetting.Item2));

                if (sqlSetting.Item1.ConnectionString.IsNullOrEmpty()) return await Task.FromResult((new List<T>(), Constants.DbConnectionStringIncorrect));

                using (var sqlCon = new SqlConnection(sqlSetting.Item1.ConnectionString))
                using (var sqlCmd = new SqlCommand(sqlCommand, sqlCon))
                {
                    if (sqlCon.State == ConnectionState.Closed)
                        sqlCon.Open();

                    using (var reader = sqlCmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        if (reader.HasRows)
                        {
                            list = reader.ToMapList<T>().Item1;
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
