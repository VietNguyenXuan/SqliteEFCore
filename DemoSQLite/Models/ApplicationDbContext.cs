using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSQLite.Models
{
  internal class ApplicationDbContext:DbContext
  {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      /*
      var sqlitePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
       @"McProtocol_EntityFrameworkCoreNet2_Database_Update\\database.db");
      if (!Directory.Exists(sqlitePath)) Directory.CreateDirectory(sqlitePath); optionsBuilder.UseSqlite("Data Source=" + sqlitePath + "\\database.db");
      */
      //optionsBuilder.UseSqlite(@"Data Source=C:\Users\19146\OneDrive\Máy tính\DemoSQLite\DB\\Database.db");
      optionsBuilder.UseSqlite($"Data Source={Application.StartupPath}/DB.db");
    }
    public DbSet<Machine> Machines { get; set; }
    public DbSet<Device> Devices { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Device>()
          .HasOne(p => p.Machine)
          .WithMany(b => b.Devices)
          .HasForeignKey(p => p.MachineId);
    }
  }
}
