using MusteriTakip.Common.Items;
using MusteriTakip.Common.Models.Abstract;
using System;
using System.Threading.Tasks;

namespace MusteriTakip.Data.Interfaces.Abstract
{
    /// <summary>
    /// Author: Can DOĞU
    /// </summary>
    public interface IClientRepository
    {
        Task<ResultItem> GetAll(Func<ClientItem> filter = null);
        Task<ResultItem> Remove(ClientItem item);
        Task<ResultItem> Add(ClientItem item);
        Task<ResultItem> Update(ClientItem item);
    }
}
