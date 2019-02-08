using Microsoft.EntityFrameworkCore;
using SQLAutomapperSample.DataAccess.Models;
using System.Collections.Generic;

namespace SQLAutomapperSample.DataAccess
{
    public class SampleContext : DbContext
    {
        public DbSet<SampleOrder> SampleOrderDbSet { get; set; }

        public SampleContext(DbContextOptions<SampleContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
