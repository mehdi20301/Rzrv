using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace RZRV.EntityFrameworkCore
{
    public static class RZRVDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<RZRVDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<RZRVDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}