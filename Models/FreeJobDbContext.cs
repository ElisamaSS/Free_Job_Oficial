using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Pilot_FreeJob.Models
{
    public class FreeJobDbContext: DbContext
    {
        public FreeJobDbContext(DbContextOptions<FreeJobDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }

    }

}
