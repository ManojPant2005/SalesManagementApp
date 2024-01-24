using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using SalesManagementApp.Data;
using SalesManagementApp.Entities;
using SalesManagementApp.Extensions;
using SalesManagementApp.Models.ReportModel;
using SalesManagementApp.Services.Contracts;
using Syncfusion.Blazor.Grids;
using static System.Reflection.Metadata.BlobBuilder;

namespace SalesManagementApp.Services
{
    public class SalesOrderReportService : ISalesOrderReportService
    {
        private readonly SalesManageDbContext salesManageDbContext;

        public AuthenticationStateProvider AuthenticationStateProvider { get; }

        public SalesOrderReportService(SalesManageDbContext salesManageDbContext )
        {
            this.salesManageDbContext = salesManageDbContext;
         
        }
        //SR
        public async Task<List<GroupFieldPriceModel>> GetEmployeePricePerMonthData()
        {
            try
            {
               

                var reportData = await (from s in this.salesManageDbContext.SalesOrderReports
                                        where s.EmployeeId == 9
                                        group s by s.OrderDateTime.Month into GroupedData
                                        orderby GroupedData.Key
                                        select new GroupFieldPriceModel
                                        {
                                            GroupedFieldKey = (
                                                GroupedData.Key == 1 ? "Jan" :
                                                GroupedData.Key == 2 ? "Feb" :
                                                GroupedData.Key == 3 ? "Mar" :
                                                GroupedData.Key == 4 ? "Apr" :
                                                GroupedData.Key == 5 ? "May" :
                                                GroupedData.Key == 6 ? "Jun" :
                                                GroupedData.Key == 7 ? "Jul" :
                                                GroupedData.Key == 8 ? "Aug" :
                                                GroupedData.Key == 9 ? "Sep" :
                                                GroupedData.Key == 10 ? "Oct" :
                                                GroupedData.Key == 11 ? "Nov" :
                                                GroupedData.Key == 12 ? "Dec" :
                                                ""
                                            ),
                                            Price = Math.Round(GroupedData.Sum(o => o.OrderItemPrice), 2)

                                        }).ToListAsync();


                return reportData;
            }
            catch (Exception)
            {

                throw;
            }
   }



        public async Task<List<GroupFieldQtyModel>> GetQtyPerProductCategory()
        {
            try
            {
                

                var reportData = await (from s in this.salesManageDbContext.SalesOrderReports
                                        group s by s.ProductCategoryName into GroupedData
                                        orderby GroupedData.Key
                                        select new GroupFieldQtyModel
                                        {
                                            GroupFieldKey = GroupedData.Key,
                                            Qty = GroupedData.Sum(oi => oi.OrderItemQty)
                                        }).ToListAsync();

                return reportData;
               
            }
            catch(Exception) 
            {
                throw;
            }
        }
        //TL
        public async Task<List<GroupFieldPriceModel>> GetGrossSalesPerTeamMemberData()
        {
            try
            {
                

                List<int> teamMemberIds = await GetTeamMembersIds(3);

                var reportData = await (from s in this.salesManageDbContext.SalesOrderReports
                                        where teamMemberIds.Contains(s.EmployeeId)
                                        group s by s.EmployeeFirstName into GroupedData
                                        orderby GroupedData.Key
                                        select new GroupFieldPriceModel
                                        {
                                            GroupedFieldKey = GroupedData.Key,
                                            Price = Math.Round(GroupedData.Sum(oi => oi.OrderItemPrice), 2)
                                        }).ToListAsync();
                return reportData;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<GroupFieldQtyModel>> GetQtyPerTeamMemberData()
        {
            try
            {
                

                List<int> teamMemberIds = await GetTeamMembersIds(3);

                var reportData = await (from s in this.salesManageDbContext.SalesOrderReports
                                        where teamMemberIds.Contains(s.EmployeeId)
                                        group s by s.EmployeeFirstName into GroupedData
                                        orderby GroupedData.Key
                                        select new GroupFieldQtyModel
                                        {
                                            GroupFieldKey = GroupedData.Key,
                                            Qty = GroupedData.Sum(oi => oi.OrderItemQty)
                                        }).ToListAsync();
                return reportData;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private async Task<List<int>> GetTeamMembersIds(int teamLeadId)
        {
            List<int> teamMembersIds = await this.salesManageDbContext.Employees
                                       .Where(e => e.ReportToEmpId == teamLeadId)
                                       .Select(e => e.Id) .ToListAsync();
            return teamMembersIds;

        }
        //SM
        public async Task<List<LocationProductCategoryModel>> GetQtyLocationProductCatData()
        {
            try
            {
              

                var reportData = await (from s in this.salesManageDbContext.SalesOrderReports
                                        group s by s.RetailOutletLocation into GroupedData
                                        orderby GroupedData.Key
                                        select new LocationProductCategoryModel
                                        {
                                            Location = GroupedData.Key,
                                            MountainBikes = GroupedData.Where(p => p.ProductCategoryId == 1).Sum(o => o.OrderItemQty),
                                            RoadBikes = GroupedData.Where(p => p.ProductCategoryId == 2).Sum(o => o.OrderItemQty),
                                            Camping = GroupedData.Where(p => p.ProductCategoryId == 3).Sum(o => o.OrderItemQty),
                                            Hiking = GroupedData.Where(p => p.ProductCategoryId == 4).Sum(o => o.OrderItemQty),
                                            Boots = GroupedData.Where(p => p.ProductCategoryId == 5).Sum(o => o.OrderItemQty),

                                        }).ToListAsync();

            return reportData;
            
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<GroupFieldQtyModel>> GetQtyPerLocationData()
        {
            try
            {
                

                var reportData = await(from s in this.salesManageDbContext.SalesOrderReports
                                       group s by s.RetailOutletLocation into GroupData
                                       orderby GroupData.Key
                                       select new GroupFieldQtyModel
                                       {
                                           GroupFieldKey = GroupData.Key,
                                           Qty = GroupData.Sum(o => o.OrderItemQty)
                                       }).ToListAsync();
                return reportData;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<MonthLocationModel>> GetQtyPerMonthLocationData()
        {
            try
            {
                

                var reportData = await (from s in this.salesManageDbContext.SalesOrderReports
                                        where s.OrderDateTime.Year == DateTime.Now.Year
                                        group s by s.OrderDateTime.Month into GroupedData
                                        orderby GroupedData.Key
                                        select new MonthLocationModel
                                        {
                                            Month = (
                                                GroupedData.Key == 1 ? "Jan" :
                                                GroupedData.Key == 2 ? "Feb" :
                                                GroupedData.Key == 3 ? "Mar" :
                                                GroupedData.Key == 4 ? "Apr" :
                                                GroupedData.Key == 5 ? "May" :
                                                GroupedData.Key == 6 ? "Jun" :
                                                GroupedData.Key == 7 ? "Jul" :
                                                GroupedData.Key == 8 ? "Aug" :
                                                GroupedData.Key == 9 ? "Sep" :
                                                GroupedData.Key == 10 ? "Oct" :
                                                GroupedData.Key == 11 ? "Nov" :
                                                GroupedData.Key == 12 ? "Dec" :
                                                ""
                                            ),
                                            TX = GroupedData.Where(l => l.RetailOutletLocation == "TX").Sum(o => o.OrderItemQty),
                                            CA = GroupedData.Where(l => l.RetailOutletLocation == "CA").Sum(o => o.OrderItemQty),
                                            NY = GroupedData.Where(l => l.RetailOutletLocation == "NY").Sum(o => o.OrderItemQty),
                                            WA = GroupedData.Where(l => l.RetailOutletLocation == "WA").Sum(o => o.OrderItemQty)
                                        }).ToListAsync();
                return reportData;
            }

            catch (Exception)
            {

                throw;
            }
        }


        
    }
    
}