using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrudOperationUsingFirstApproach1.Models;

namespace CrudOperationUsingFirstApproach1.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext (DbContextOptions<EmployeeContext> options)
            : base(options)
        {
        }

        public DbSet<CrudOperationUsingFirstApproach1.Models.EmployeeData> EmployeeData { get; set; } = default!;
    }
}
