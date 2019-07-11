using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;

namespace Payroll.Models
{
    public class CMSContext : DbContext
    {
        public DbSet<LeaveModel> Leave { get; set; }
        public DbSet<PayrollModel> Payroll { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=payroll;user=root;password=''");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<LeaveModel>(entity =>
            {
                entity.HasKey(e => e.id);
                //entity.Property(e => e.fname).IsRequired();
            });

        }
    }
}
