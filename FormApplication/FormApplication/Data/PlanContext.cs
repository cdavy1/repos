using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FormApplication.Models
{
    public class PlanContext : DbContext
    {
        public PlanContext (DbContextOptions<PlanContext> options)
            : base(options)
        {
        }

        public DbSet<FormApplication.Models.BCPPlan> BCPPlan { get; set; }
    }
}
