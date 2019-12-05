﻿using System;
using System.Collections.Generic;

namespace LB.Chinook.WebAPI.WebApp.Models
{
    public partial class Employees
    {
        public Employees()
        {
            Customers = new HashSet<Customers>();
            InverseReportsToNavigation = new HashSet<Employees>();
        }

        public long EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public long? ReportsTo { get; set; }
        public byte[] BirthDate { get; set; }
        public byte[] HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }

        public virtual Employees ReportsToNavigation { get; set; }
        public virtual ICollection<Customers> Customers { get; set; }
        public virtual ICollection<Employees> InverseReportsToNavigation { get; set; }
    }
}
