using SalesManagementApp.Data;
using SalesManagementApp.Extensions;
using SalesManagementApp.Models;
using SalesManagementApp.Services.Contracts;

namespace SalesManagementApp.Services
{
    public class ProductService : IProductService
    {
        private readonly SalesManageDbContext salesManageDbContext;

        public ProductService(SalesManageDbContext salesManageDbContext)
        {
            this.salesManageDbContext = salesManageDbContext;
        }
        public async Task<List<ProductModel>> GetProducts()
        {
            try
            {
                var products = await this.salesManageDbContext.Products.Convert(salesManageDbContext);
                return products;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
