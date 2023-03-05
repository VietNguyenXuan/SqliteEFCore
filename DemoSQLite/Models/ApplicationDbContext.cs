using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSQLite.Models
{
  internal class ApplicationDbContext : DbContext
  {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlite($"Data Source={Application.StartupPath}/DB.db");
    }
    public DbSet<Machine> Machines { get; set; }
    public DbSet<Device> Devices { get; set; }
    public DbSet<Line> Lines { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      //modelBuilder.Entity<Device>()
      //    .HasOne(p => p.Machine)
      //    .WithMany(b => b.Devices)
      //    .HasForeignKey(p => p.MachineId);
    }
  }
}
