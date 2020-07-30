using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using TechnicalAssessment.Model;

namespace TechnicalAssessment.DBContexts
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Lang> Langs { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<HolidayHome> HolidayHomes { get; set; }
        public DbSet<HolidayHomeLang> HolidayHomeLangs { get; set; }
        public DbSet<HolidayHomeFreeDay> HolidayHomeFreeDays { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DefaultDataStatic.OnModelCreatingLang(ref modelBuilder);
            DefaultDataStatic.OnModelCreatingOwner(ref modelBuilder);
            DefaultDataStatic.OnModelCreatingHolidayHome(ref modelBuilder);
            DefaultDataStatic.OnModelCreatingHolidayHomeLang(ref modelBuilder);
            DefaultDataStatic.OnModelCreatingHolidayHomeFreeDay(ref modelBuilder);
        }
    }
}
