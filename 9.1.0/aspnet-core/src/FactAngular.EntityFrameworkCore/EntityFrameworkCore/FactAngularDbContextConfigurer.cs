using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace FactAngular.EntityFrameworkCore
{
    public static class FactAngularDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<FactAngularDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<FactAngularDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
