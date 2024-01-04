using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppEMS.Models;

namespace WebAppEMS.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext (DbContextOptions<EmployeeDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppEMS.Models.EmpProfile> EmpProfile { get; set; } = default!;

        public DbSet<WebAppEMS.Models.DeptMaster>? DeptMaster { get; set; }
    }
}
