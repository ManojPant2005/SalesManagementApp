using SalesManagementApp.Models.ReportModel;

namespace SalesManagementApp.Services.Contracts
{
    public interface ISalesOrderReportService
    {
        //SR
        Task<List<GroupFieldPriceModel>> GetEmployeePricePerMonthData();
        Task<List<GroupFieldQtyModel>> GetQtyPerProductCategory();

        //TL
        Task<List<GroupFieldPriceModel>> GetGrossSalesPerTeamMemberData();
        Task<List<GroupFieldQtyModel>> GetQtyPerTeamMemberData();

        //SM
        Task<List<LocationProductCategoryModel>> GetQtyLocationProductCatData();
        Task<List<GroupFieldQtyModel>> GetQtyPerLocationData();
        Task<List<MonthLocationModel>> GetQtyPerMonthLocationData();

    }
}
