using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GCE.Common.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace GCE.Common.Infrastructure.ConnectionString
{
    class GCEContextDesignTimeFactory : IDesignTimeDbContextFactory<GCEContext>
    {
        public GCEContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<GCEContext>();

            builder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=gce;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new GCEContext(builder.Options);
        }
    }
}
