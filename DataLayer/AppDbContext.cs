using System;
using Microsoft.EntityFrameworkCore;
using PlateformService.Model;

namespace PlateformService.DataLayer;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<Platform> platforms { get; set; }
}
