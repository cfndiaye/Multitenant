using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Core.Contracts;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure.Persistence
{
    public class DbContextFactory //: IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public DbContextFactory(ITenantService tenantService)
        {
            _tenantService = tenantService;
        }
        public DbContextFactory()
        {
            
        }
        ITenantService _tenantService;
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            //_tenantService = new TenantService();
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            return new ApplicationDbContext(optionsBuilder.Options, _tenantService);
        }
    }
}