using MusteriTakip.Common.Items;
using MusteriTakip.Common.Models.Abstract;
using MusteriTakip.Data.Interfaces.Abstract;
using MusteriTakip.Data.Repositories.Abstract;
using MusteriTakip.Service.Interfaces.Abstract;
using MusteriTakip.Service.Services.Base;
using System;
using System.Threading.Tasks;

namespace MusteriTakip.Service.Services.Abstract
{
    /// <summary>
    /// Author: Can DOĞU
    /// </summary>
    public class ClientService : ServiceBase, IClientService
    {
        private readonly IClientRepository clientRepository;

        public ClientService()
        {
            clientRepository = new ClientRepository();
        }

        public async Task<ResultItem> Add(ClientItem item)
        {
            return await clientRepository.Add(item);
        }

        public async Task<ResultItem> GetAll(Func<ClientItem, bool> filter = null)
        {
            return await clientRepository.GetAll(filter);
        }

        public async Task<ResultItem> Remove(ClientItem item)
        {
            return await clientRepository.Remove(item);
        }

        public async Task<ResultItem> Update(ClientItem item)
        {
            return await clientRepository.Update(item);
        }
    }
}
