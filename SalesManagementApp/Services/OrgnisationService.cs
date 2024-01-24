using SalesManagementApp.Data;
using SalesManagementApp.Extensions;
using SalesManagementApp.Models;
using SalesManagementApp.Services.Contracts;

namespace SalesManagementApp.Services
{
    public class OrganisationService : IOrgnisationService
    {
        private readonly SalesManageDbContext salesManagementDbContext;

        public OrganisationService(SalesManageDbContext salesManagementDbContext)
        {
            this.salesManagementDbContext = salesManagementDbContext;
        }
        
        public async Task<List<OrgnisationModel>> GetHierarchy()
        {
            try
            {
                return await this.salesManagementDbContext.Employees.ConvertToHierarchy(salesManagementDbContext);
            }
            
            catch (Exception)
            {

                throw;
            }
        }
    }
}