using Microsoft.EntityFrameworkCore;
using SalesManagementApp.Data;
using SalesManagementApp.Entities;
using SalesManagementApp.Extensions;
using SalesManagementApp.Models;
using SalesManagementApp.Services.Contracts;

namespace SalesManagementApp.Services
{
    public class EmployeeManagementService : IEmployeeManagementService
    {
        private readonly SalesManageDbContext salesManageDbContext;

        public EmployeeManagementService(SalesManageDbContext salesManageDbContext)
        {
            this.salesManageDbContext = salesManageDbContext;
        }

        public async Task<Employee> AddEmployee(EmployeeModel employeemodel)
        {
            try
            {
                Employee employeeToAdd = employeemodel.Convert();

                var result = await this.salesManageDbContext.Employees.AddAsync(employeeToAdd);

                await this.salesManageDbContext.SaveChangesAsync();

                return result.Entity;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteEmployee(int id)
        {
            try
            {
                var employee = await this.salesManageDbContext.Employees.FindAsync(id);
                if (employee != null) 
                {
                    this.salesManageDbContext.Employees.Remove(employee);
                    await this.salesManageDbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<EmployeeModel>> GetEmployees()
        {
            try
            {
                return await this.salesManageDbContext.Employees.Convert();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<EmployeeJobTitle>> GetJobTitles()
        {
            try
            {
                return await this.salesManageDbContext.EmployeeJobTitles.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<ReportToModel>> GetReportToEmployees()
        {
            try
            {
                var employees = await (from e in this.salesManageDbContext.Employees
                                       join j in this.salesManageDbContext.EmployeeJobTitles
                                       on e.EmployeeJobTitleId equals j.EmployeeJobTitleId
                                       where j.Name.ToUpper() == "TL" ||  j.Name.ToUpper() == "SM"
                                       select new ReportToModel
                                       {
                                           ReportToEmpId = e.Id,
                                           ReportToName = e.FirstName + " " + e.LastName.Substring(0,1).ToUpper() + "."
                                       }).ToListAsync();
                employees.Add(new ReportToModel { ReportToEmpId = null, ReportToName = "<None>" });

                return employees.OrderBy(o => o.ReportToEmpId).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateEmployee(EmployeeModel employeeModel)
        {
            try
            {
                var employeeUpdate = await this.salesManageDbContext.Employees.FindAsync(employeeModel.Id);

                if (employeeUpdate != null)
                {
                    employeeUpdate.FirstName = employeeModel.FirstName;
                    employeeUpdate.LastName = employeeModel.LastName;
                    employeeUpdate.ReportToEmpId = employeeModel.ReportToEmpId;
                    employeeUpdate.DateOfBirth = employeeModel.DateOfBirth;
                    employeeUpdate.ImagePath = employeeModel.ImagePath;
                    employeeUpdate.Gender = employeeModel.Gender;
                    employeeUpdate.Email = employeeModel.Email;
                    employeeUpdate.EmployeeJobTitleId = employeeModel.EmployeeJobTitleId;

                    await this.salesManageDbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
