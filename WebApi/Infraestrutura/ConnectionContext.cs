using Microsoft.EntityFrameworkCore;
using System;
using WebApi.Domain.Model.CompanyAggregate;
using WebApi.Domain.Model.EmployeeAggregate;

namespace WebApi.Infraestrutura
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Company { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          => optionsBuilder.UseNpgsql(
              "Server=localhost;" +
              "Port=5432;Database=employee_sample;" +
              "User Id=postgres;" +
              "Password=123;");
    }
}
