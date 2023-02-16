using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using xyz.Authorization.Roles;
using xyz.Authorization.Users;
using xyz.MultiTenancy;

namespace xyz.EntityFrameworkCore
{
    public class xyzDbContext : AbpZeroDbContext<Tenant, Role, User, xyzDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public xyzDbContext(DbContextOptions<xyzDbContext> options)
            : base(options)
        {
        }
    }
}
