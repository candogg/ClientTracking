using MusteriTakip.Common.Helpers;
using MusteriTakip.Common.Items;
using MusteriTakip.Common.Models.Abstract;
using MusteriTakip.Data.Interfaces.Abstract;
using MusteriTakip.Data.Repositories.Base;
using System;
using System.Threading.Tasks;

namespace MusteriTakip.Data.Repositories.Abstract
{
    /// <summary>
    /// Author: Can DOĞU
    /// </summary>
    public class ClientRepository : RepositoryBase, IClientRepository
    {
        public async Task<ResultItem> Add(ClientItem item)
        {
            var result = new ResultItem();

            try
            {

            }
            catch (Exception ex)
            {
                result.IsOk = false;
                result.Message = ex.ToString();
            }

            return await Task.FromResult(result);
        }

        public async Task<ResultItem> GetAll(Func<ClientItem, bool> filter = null)
        {
            var result = new ResultItem();

            try
            {
                result.Data = await SqlHelper.Instance.GetItems(filter);
            }
            catch (Exception ex)
            {
                result.IsOk = false;
                result.Message = ex.ToString();
            }

            return await Task.FromResult(result);
        }

        public async Task<ResultItem> Remove(ClientItem item)
        {
            var result = new ResultItem();

            try
            {

            }
            catch (Exception ex)
            {
                result.IsOk = false;
                result.Message = ex.ToString();
            }

            return await Task.FromResult(result);
        }

        public async Task<ResultItem> Update(ClientItem item)
        {
            var result = new ResultItem();

            try
            {

            }
            catch (Exception ex)
            {
                result.IsOk = false;
                result.Message = ex.ToString();
            }

            return await Task.FromResult(result);
        }
    }
}
