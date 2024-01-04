using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspNetCoreAngularApp.Server.Models;

namespace AspNetCoreAngularApp.Server.Data
{
    public class AspNetCoreAngularAppServerContext : DbContext
    {
        public AspNetCoreAngularAppServerContext (DbContextOptions<AspNetCoreAngularAppServerContext> options)
            : base(options)
        {
        }

        public DbSet<AspNetCoreAngularApp.Server.Models.Employee> Employee { get; set; } = default!;
    }
}
