using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using MovieReportApp0.Models;


namespace MovieReportApp0.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        //   protected override void OnModelCreating(ModelBuilder modelBuilder)
        //   {
        //      modelBuilder.UseSerialColumns();
        //  }
        public DbSet<Models.Genre> Geners { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieGenreModels> MovieGanres { get; set; }
        public DbSet<ReviewModels> Reviews { get; set; }
        public DbSet<UserModels> Users { get; set; }


    }
}
