using SalesManagementApp.Data;
using SalesManagementApp.Extensions;
using SalesManagementApp.Models;
using SalesManagementApp.Services.Contracts;

namespace SalesManagementApp.Services
{
    public class ClientService : IClientService
    {
        private readonly SalesManageDbContext salesManageDbContext;

        public ClientService(SalesManageDbContext salesManageDbContext)
        {
            this.salesManageDbContext = salesManageDbContext;
        }
        public async Task<List<ClientModel>> GetClients()
        {
			try
			{
                return await this.salesManageDbContext.Clients.Convert(salesManageDbContext);
			}
			catch (Exception)
			{

				throw;
			}
        }
    }
}
