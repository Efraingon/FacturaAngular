using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using FactAngular.Authorization.Roles;
using FactAngular.Authorization.Users;
using FactAngular.MultiTenancy;

namespace FactAngular.EntityFrameworkCore
{
    public class FactAngularDbContext : AbpZeroDbContext<Tenant, Role, User, FactAngularDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public FactAngularDbContext(DbContextOptions<FactAngularDbContext> options)
            : base(options)
        {
        }
    }
}
