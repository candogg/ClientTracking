using MusteriTakip.Common.Items;
using MusteriTakip.Common.Models.Abstract;
using System;
using System.Threading.Tasks;

namespace MusteriTakip.Service.Interfaces.Abstract
{
    /// <summary>
    /// Author: Can DOĞU
    /// </summary>
    public interface IClientService
    {
        Task<ResultItem> GetAll(Func<ClientItem, bool> filter = null);
        Task<ResultItem> Remove(ClientItem item);
        Task<ResultItem> Add(ClientItem item);
        Task<ResultItem> Update(ClientItem item);
    }
}
