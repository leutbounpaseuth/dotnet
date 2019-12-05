using LB.Chinook.WebAPI.WebApp.ViewModels;
using System.Collections.Generic;

namespace LB.Chinook.WebAPI.WebApp.Repositories
{
    public interface IEmployeeRepository
    {
        List<EmployeeViewModel> GetEmployees();
    }
}