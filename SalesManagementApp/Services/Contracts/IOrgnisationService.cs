using SalesManagementApp.Models;

namespace SalesManagementApp.Services.Contracts
{
    public interface IOrgnisationService
    {
        Task<List<OrgnisationModel>> GetHierarchy();
    }
}
