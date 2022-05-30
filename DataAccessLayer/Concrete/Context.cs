using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=BURAK\\SQLEXPRESS;database=TaskManager;integrated security=true");
        }
        public DbSet<Day> TblDay { get; set; }
        public DbSet<Month> TblMonth { get; set; }
        public DbSet<TaskImportance> TblTaskImportance { get; set; }
        public DbSet<TaskStatuse> TblTaskStatus { get; set; }
        public DbSet<User> TblUser { get; set; }
        public DbSet<Week> TblWeek { get; set; }
    }
}
