using LB.Chinook.WebAPI.WebApp.Models;
using LB.Chinook.WebAPI.WebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LB.Chinook.WebAPI.WebApp.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private ChinookContext db;

        public EmployeeRepository(ChinookContext db)
        {
            this.db = db;
        }

        public List<EmployeeViewModel> GetEmployees()
        {
            if (db != null)
            {
                List<EmployeeViewModel> employees = new List<EmployeeViewModel>();

                var result = from o in db.Employees
                             orderby o.FirstName ascending, o.LastName ascending
                             select o;

                foreach (var r in result)
                {
                    EmployeeViewModel employee = new EmployeeViewModel();
                    employee.EmployeeId = r.EmployeeId;
                    employee.FirstName = r.FirstName;
                    employee.LastName = r.LastName;
                    employee.Phone = r.Phone;
                    employee.Email = r.Email;

                    employees.Add(employee);
                }

                return employees;
            }

            return null;
        }
    }
}