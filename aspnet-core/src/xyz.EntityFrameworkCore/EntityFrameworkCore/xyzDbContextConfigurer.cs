using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace xyz.EntityFrameworkCore
{
    public static class xyzDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<xyzDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<xyzDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
