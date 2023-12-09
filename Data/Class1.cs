namespace Data;
using Model;
using Microsoft.EntityFrameworkCore;
using System.Net.Security;
using System.Collections.Generic;

public class DataContex : DbContext
{
    public DbSet<Standing> Standings => Set<Standing>();
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       optionsBuilder.UseSqlite("Data Source=standings.db");
    }
    public DataContex() 
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }
}